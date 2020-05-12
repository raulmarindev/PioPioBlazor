using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace PioPioBlazor.Models
{
    public class CultureEqualityComparer : IEqualityComparer<CultureInfo>
    {
        public bool Equals([AllowNull] CultureInfo x, [AllowNull] CultureInfo y)
        {
            return x.TwoLetterISOLanguageName == y.TwoLetterISOLanguageName;
        }

        public int GetHashCode([DisallowNull] CultureInfo obj)
        {
            return obj.TwoLetterISOLanguageName.GetHashCode();
        }
    }
}