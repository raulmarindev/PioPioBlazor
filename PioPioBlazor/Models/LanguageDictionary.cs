using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PioPioBlazor.Models
{
    public class LanguageDictionary : ILanguageDictionary
    {
        private readonly IDictionary<string, string> _languages;

        public LanguageDictionary()
        {
            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            _languages = cultures.Distinct(new CultureEqualityComparer())
                .ToDictionary(c => c.TwoLetterISOLanguageName, c => c.EnglishName);
            _languages.Add("und", "Undetermined");
        }

        public string this[string key]
        {
            get
            {
                if (_languages.ContainsKey(key))
                {
                    return _languages[key];
                }
                return _languages["und"];
            }
        }
    }
}