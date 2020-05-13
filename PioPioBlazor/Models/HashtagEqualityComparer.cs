using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace PioPioBlazor.Models
{
    public class HashtagEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals([AllowNull] string x, [AllowNull] string y)
        {
            return x.ToLower() == y.ToLower();
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return obj.ToLower().GetHashCode();
        }
    }
}