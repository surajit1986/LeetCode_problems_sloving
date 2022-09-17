using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public  class CharCounts
    {
        private string _ipStr = string.Empty;
        Dictionary<char, int> _dict = new Dictionary<char, int>();
        public CharCounts(string ipStr)
        {
            _ipStr = ipStr;
        }

        public void GetCounts()
        {
            foreach(char c in _ipStr)
            {
                if (_dict.ContainsKey(c))
                {
                    _dict[c] = _dict[c] + 1;
                }
                else
                {
                    _dict.Add(c, 1);
                }

            }

            foreach(var key in _dict.Keys)
            {
                Console.WriteLine(key + " " + _dict[key]);
            }
        }
    }
}
