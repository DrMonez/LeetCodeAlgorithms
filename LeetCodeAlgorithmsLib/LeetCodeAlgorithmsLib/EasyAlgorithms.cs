using System;
using System.Collections.Generic;

namespace LeetCodeAlgorithmsLib
{
    public class EasyAlgorithms
    {
        public int NumJewelsInStones(string J, string S)
        {
            var count = 0;
            for (var i = 0; i < J.Length; i++)
            {
                for (var j = 0; j < S.Length; j++)
                    if (S[j] == J[i])
                        count++;
            }

            return count;
        }

        public int NumUniqueEmails(string[] emails)
        {
            var seen = new HashSet<string>();
            foreach (var email in emails)
            {
                int i = email.IndexOf('@');
                var local = email.Substring(0, i);
                if (local.Contains("+"))
                    local = local.Substring(0, local.IndexOf('+'));
                local = local.Replace(".", "");
                var host = email.Substring(i);
                seen.Add(local + host);
            }
            return seen.Count;
        }

    }
}
