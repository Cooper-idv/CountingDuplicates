using System;
using System.Collections.Generic;
using System.Text;

namespace CountingDuplicates
{
    public class Kata004
    {
        public static int DuplicateCount(string str)
        {
            int charDupCount = 0;
            if (string.IsNullOrEmpty(str))
            {
                return charDupCount;
            }
            var dict = new Dictionary<char, int>();
            foreach (char c in str.ToLower())
            {
                if (dict.ContainsKey(c))
                {
                    dict[c] = dict[c]+1;
                }
                else
                {
                    dict.Add(c,1);
                }
            }

            foreach (var item in dict)
            {
                if (item.Value > 1)
                    charDupCount++;
            }

            return charDupCount;
        }
    }
}
