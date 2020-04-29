using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LinqToTwitter;
using Microsoft.Extensions.Configuration;
using PioPioBlazor.Models;

namespace PioPioBlazor.Services
{
    public class TwitterService
    {
        private const int TweetTextMaxLength = 100;
        private readonly IConfiguration _configuration;
        private TwitterContext _twitterContext;

        public TwitterService(IConfiguration configuration)
        {
            _configuration = configuration;
            _twitterContext = new TwitterContext(CreateMvcAuthorizer());
        }

        private MvcAuthorizer CreateMvcAuthorizer()
        {
            return new MvcAuthorizer
            {
                CredentialStore = new InMemoryCredentialStore()
                {
                    ConsumerKey = _configuration["Twitter_ConsumerKey"],
                    ConsumerSecret = _configuration["Twitter_ConsumerSecret"],
                    OAuthToken = _configuration["Twitter_AccessToken"],
                    OAuthTokenSecret = _configuration["Twitter_AccessTokenSecret"]
                }
            };
        }

        public async Task<IEnumerable<Tweet>> GetHomeTimelineTweets()
        {
            const int MaxTotalResults = 20;

            // sinceID is the oldest id you already have for this search term
            // CurrentMaxId is used after the first query to track current session
            ulong? currentMaxID = null, previousMaxID = ulong.MaxValue;
            var partialStatuses = new List<Status>();
            var combinedStatuses = new List<Status>();
            const int MinFavoriteCount = 20;

            do
            {
                try
                {
                    partialStatuses = await _twitterContext.Status
                    .Where(FilterStatuses(currentMaxID))
                    .ToListAsync();

                    // one less than the newest id you've just queried
                    currentMaxID = partialStatuses.Min(status => status.StatusID) - 1;

                    Debug.Assert(currentMaxID < previousMaxID);

                    previousMaxID = currentMaxID;

                    combinedStatuses.AddRange(partialStatuses.Where(s => s.FavoriteCount > MinFavoriteCount));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (partialStatuses.Any() && (combinedStatuses.Count() < MaxTotalResults));

            return MapStatusesToTweets(combinedStatuses);
        }

        private static IEnumerable<Tweet> MapStatusesToTweets(List<Status> combinedTweets)
        {
            return combinedTweets
                        .OrderByDescending(s => s.FavoriteCount)
                        .Select(s =>
                        {
                            var mediaEntities = s.Entities.MediaEntities;
                            var hashTagEntities = s.Entities.HashTagEntities;
                            var hashTags = new List<string>();
                            if (hashTagEntities != null && hashTagEntities.Any())
                            {
                                hashTags.AddRange(hashTagEntities.Select(e => $"#{e.Text}"));
                            }

                            return new Tweet
                            {
                                FavoriteCount = s.FavoriteCount,
                                Text = $"{s.Text.Substring(0, Math.Min(TweetTextMaxLength, s.Text.Length))}{(s.Text.Length > TweetTextMaxLength ? "..." : string.Empty)}",
                                UserScreenName = s.User.ScreenNameResponse,
                                Url = $"https://twitter.com/{s.User.ScreenNameResponse}/status/{s.StatusID}",
                                CreatedAt = s.CreatedAt,
                                RetweetCount = s.RetweetCount,
                                UserProfileImageUrl = s.User.ProfileImageUrl.Replace("http:", "https:"),
                                ImageUrl = mediaEntities.Any() ? mediaEntities[0].MediaUrl.Replace("http:", "https:") : "/images/twitter-logo.svg",
                                ImageAlt = mediaEntities.Any() ? mediaEntities[0].AltText : string.Empty,
                                UserProfileUrl = $"https://twitter.com/{s.User.ScreenNameResponse}",
                                HashTags = hashTags
                            };
                        });
        }

        private static Expression<Func<Status, bool>> FilterStatuses(ulong? maxID)
        {
            const ulong SinceID = 1;
            const int MaxTweetsToReturn = 200;

            var status = Expression.Parameter(typeof(Status), "status");
            var expression = @$"status.Type == @0 &&
                        status.Count == @1 &&
                        status.ExcludeReplies == false &&
                        status.TweetMode == @2 &&
                        status.SinceID == @3
";

            if (maxID.HasValue)
            {
                expression += " && status.MaxID == @4";
            }

            return (Expression<Func<Status, bool>>)DynamicExpressionParser.ParseLambda(
                new[] { status }, typeof(bool), expression, StatusType.Home, MaxTweetsToReturn, TweetMode.Compat, SinceID, maxID
                );
        }
    }
}