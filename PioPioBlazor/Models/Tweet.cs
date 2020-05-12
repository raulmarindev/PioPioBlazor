using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PioPioBlazor.Models
{
    public class Tweet
    {
        private static readonly IDictionary<string, string> _languages;

        static Tweet()
        {
            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            _languages = cultures.Distinct(new CultureEqualityComparer())
                .ToDictionary(c => c.TwoLetterISOLanguageName, c => c.EnglishName);
            _languages.Add("und", "Undetermined");
        }

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

        public static IDictionary<string, string> Languages
        {
            get
            {
                return _languages;
            }
            private set
            {
            }
        }
    }
}