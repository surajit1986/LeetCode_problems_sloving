using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Palindrome
    {
        public bool CheckPalinDrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            while (i <= j)
            {
                while ((i < j) && (String.IsNullOrWhiteSpace(str[i].ToString()))){
                    i++;
                }

                while ((i < j) && (String.IsNullOrWhiteSpace(str[j].ToString())))
                {
                    j--;
                }

                if (str[i].ToString().ToUpper() != str[j].ToString().ToUpper()) return false;

                i++;
                j--;
            }
            return true;
        }
    }
}
