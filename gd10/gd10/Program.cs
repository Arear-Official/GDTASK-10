using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace gd10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input text");
            string s = Console.ReadLine();
            Regex regex = new Regex("\\b[а-я]+\\b");
            MatchCollection match= regex.Matches(s);
            for (int i = 0; i < match.Count; i++)
            {
               s = regex.Replace(s, match[i].ToString().Replace(match[i].ToString()[0].ToString(), "") + match[i].ToString()[0] + "aй", 1);
            }
            Console.WriteLine(s);
        }
    }
}
