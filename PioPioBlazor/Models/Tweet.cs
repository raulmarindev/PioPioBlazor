using System;
using System.Collections.Generic;

namespace PioPioBlazor.Models
{
    public class Tweet
    {
        private static IDictionary<string, string> _languages;

        static Tweet()
        {
            _languages = new Dictionary<string, string>
            {
                ["en"] = "English",
                ["ar"] = "French",
                ["bn"] = "Bengali",
                ["cs"] = "Czech",
                ["da"] = "Danish",
                ["de"] = "German",
                ["el"] = "Greek",
                ["es"] = "Spanish",
                ["fa"] = "Persian",
                ["fi"] = "Finnish",
                ["fil"] = "Filipino",
                ["fr"] = "French",
                ["he"] = "Hebrew",
                ["hi"] = "Hindi",
                ["hu"] = "Hungarian",
                ["id"] = "Indonesian",
                ["it"] = "Italian",
                ["ja"] = "Japanese",
                ["ko"] = "Korean",
                ["msa"] = "Msa",
                ["nl"] = "Dutch",
                ["no"] = "Norwegian",
                ["pl"] = "Polish",
                ["pt"] = "Portuguese",
                ["ro"] = "Romanian",
                ["ru"] = "Russian",
                ["sv"] = "Swedish",
                ["th"] = "Thai",
                ["tr"] = "Turkish",
                ["uk"] = "Ukranian",
                ["ur"] = "Urdu",
                ["vi"] = "Vietnamese",
                ["zh-cn"] = "Chinese",
                ["und"] = "Unknown",
            };
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