using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        public static bool ofPal(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            return true;
        }

        public static bool Palindrom(string s)
        {
            string s1 = s;
            string s2 = null;
            string s3;
            int maxpol = 0;
            bool trigger = true;
            if (ofPal(s) == false)
            for (int i = 0; i < s.Length; i++)
            {
                int ll = i;
                s3 = s2 + s[s.Length - i - 1]; // рассматриваем с конца строки
                if (ofPal(s3) == false)
                    trigger = false;  // уже не палиндром
                else
                {
                    if (ll > maxpol) // поиск длины максималлного палиндрома
                        maxpol = s2.Length + 1; // +1 из-за сдвига индекса и длины
                }
                
                s2 += s[s.Length - i - 1]; // добавляем еще один символ для проверки на палиндром
            }
            if (trigger == false)
            for (int i1 = 0; i1 < s.Length - maxpol; i1++)
            {
                s1 += s[s.Length - maxpol - i1 - 1];
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
