using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        public static bool Palindrom(string s)
        {
            string s1 = s;
            bool k = false;
            for (int i = 0; i < s.Length / 2; i++)
                if (s[i] != s[s.Length - i - 1])
                    k = true;  
            if (k == true)
            {
                for (int i = 1; i < s.Length ; i++)
                    s1 += s[s.Length - i - 1];
            }
            Console.WriteLine(s1);
            return true;
        }

        static void Main(string[] args)
        {
            string s =  Console.ReadLine();
            Palindrom(s);
            Console.ReadLine();
        }
    }
}
