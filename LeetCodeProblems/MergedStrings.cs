using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

//Return the merged string.

 

//Example 1:

//Input: word1 = "abc", word2 = "pqr"
//Output: "apbqcr"
//Explanation: The merged string will be merged as so:
//word1: a b   c
//word2:    p q   r
//merged: a p b q c r
//Example 2:

//Input: word1 = "ab", word2 = "pqrs"
//Output: "apbqrs"
//Explanation: Notice that as word2 is longer, "rs" is appended to the end.
//word1:  a b
//word2:    p q   r s
//merged: a p b q   r s
//Example 3:

//Input: word1 = "abcd", word2 = "pq"
//Output: "apbqcd"
//Explanation: Notice that as word1 is longer, "cd" is appended to the end.
//word1:  a b   c d
//word2:    p q
//merged: a p b q c d



//Constraints:

//1 <= word1.length, word2.length <= 100
//word1 and word2 consist of lowercase English letters.
namespace LeetCodeProblems
{
    public class MergedStrings
    {
        //My Solution
        //public string MergeAlternately(string word1, string word2)
        //{
        //    if (string.IsNullOrEmpty(word1)) { return word2; }

        //    if(string.IsNullOrEmpty(word2)) { return word1; }

            
        //    char[] resultWord = new char[word1.Length + word2.Length];
        //    int minLen = Math.Min(word1.Length, word2.Length);
        //    int alternateIndex = 0;

        //    for (int i = 0; i < minLen; i++)
        //    {
        //        resultWord[alternateIndex] = word1[i];
        //        alternateIndex++;
        //        resultWord[alternateIndex] = word2[i];
        //        alternateIndex++;

        //    }

        //    if (minLen < word1.Length)
        //    {
        //        for(int i = minLen; i < word1.Length; i++)
        //        {
        //            resultWord[alternateIndex] = word1[i];
        //            alternateIndex++;
        //        }
        //    }

        //    if (minLen < word2.Length)
        //    {
        //        for (int i = minLen; i < word2.Length; i++)
        //        {
        //            resultWord[alternateIndex] = word2[i];
        //            alternateIndex++;
        //        }
        //    }
           

        //    return new string(resultWord);

        //}

        //best solution
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder result = new StringBuilder();
            int count = 0;

            while ((count < word1.Length) || (count < word2.Length))
            {
                if(count< word1.Length)
                {
                    result.Append(word1[count]);
                }
                
                if (count < word2.Length)
                {
                    result.Append(word2[count]);
                }
                count++;

            }

            return result.ToString();

        }
    }
}
