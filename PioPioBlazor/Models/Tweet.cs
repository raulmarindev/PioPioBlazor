using System;
using System.Collections.Generic;

namespace PioPioBlazor.Models
{
    public class Tweet
    {
        public string Text { get; set; } = string.Empty;

        public int? FavoriteCount { get; set; }

        public int? RetweetCount { get; set; }

        public string UserScreenName { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;

        public string UserProfileImageUrl { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public string ImageAlt { get; set; } = string.Empty;

        public string UserProfileUrl { get; set; } = string.Empty;

        public IEnumerable<string> HashTags { get; set; }

        public string Language { get; set; }
    }
}