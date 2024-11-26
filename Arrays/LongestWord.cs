using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Coding_Practice.Arrays
{
    public class LongestWord
    {
        public static string LongestWordIn(string sen)
        {
            var words = sen.Split(' ');
            string res = string.Empty;
            foreach (var word in words)
            {
                if (word.Any(c => !char.IsLetter(c)))
                {
                    continue;
                }

                if(res.Length < word.Length)
                {
                    res = word;
                }
            }

            return res;
        }
    }
}
