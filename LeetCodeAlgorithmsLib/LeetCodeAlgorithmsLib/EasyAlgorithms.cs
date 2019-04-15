using System;
using System.Collections.Generic;

namespace LeetCodeAlgorithmsLib
{
    public class EasyAlgorithms
    {
        /// <summary>
        /// https://leetcode.com/problems/jewels-and-stones/
        /// </summary>
        /// <param name="J">List of jewels</param>
        /// <param name="S">List of stones</param>
        /// <returns></returns>
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

        /// <summary>
        /// https://leetcode.com/problems/unique-email-addresses/
        /// </summary>
        /// <param name="emails">List of emails</param>
        /// <returns></returns>
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

        /// <summary>
        /// https://leetcode.com/problems/design-linked-list/
        /// </summary>
        public class MyLinkedList
        {

            /** Initialize your data structure here. */
            public MyLinkedList()
            {

            }

            /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
            public int Get(int index)
            {
                return 0;
            }

            /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
            public void AddAtHead(int val)
            {

            }

            /** Append a node of value val to the last element of the linked list. */
            public void AddAtTail(int val)
            {

            }

            /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
            public void AddAtIndex(int index, int val)
            {

            }

            /** Delete the index-th node in the linked list, if the index is valid. */
            public void DeleteAtIndex(int index)
            {

            }
        }
    }
}
