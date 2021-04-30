using System;
using System.Collections.Generic;

namespace Leetcode.Problems
{
    public class LetterCombinationsOfAPhoneNumber
    {
        /// <remarks>
        /// Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.
        ///
        ///        A mapping of digit to letters(just like on the telephone buttons) is given below.Note that 1 does not map to any letters.
        ///
        ///
        ///
        ///
        ///
        ///
        ///       Example 1:
        ///
        ///
        ///       Input: digits = "23"
        ///       Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
        ///Example 2:
        ///
        ///
        ///       Input: digits = ""
        ///       Output: []
        ///Example 3:
        ///
        ///
        ///       Input: digits = "2"
        ///       Output: ["a","b","c"]
        ///
        ///
        ///Constraints:
        ///
        ///0 <= digits.length <= 4
        ///digits[i] is a digit in the range ['2', '9'].
        /// </remarks>
        public static IList<string> Solve(string digits)
        {
            // table[i] stores all characters that
            String[] table = { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            List<String> list = new List<string>();
            Queue<String> q = new Queue<String>();

            q.Enqueue("");

            while (q.Count != 0)
            {
                String s = q.Dequeue();

                // push it in the list
                if (s.Length == digits.Length)
                    list.Add(s);
                else
                {
                    String val = table[digits[s.Length] - '0'];
                    for (int i = 0; i < val.Length; i++)
                    {
                        q.Enqueue(s + val[i]);
                    }
                }
            }
            return (list);
        }
    }
}
