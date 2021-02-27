using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToRoman(397));

            Console.WriteLine(FromRoman("CCCXCVII"));
            Console.ReadKey();
        }

        static string ToRoman(int n)
        {
            string r = "";
            while (n >= 1000)
            {
                r += "M";
                n -= 1000;
            }
            while (n >= 900)
            {
                r += "CM";
                n -= 900;
            }
            while (n >= 500)
            {
                r += "D";
                n -= 500;
            }
            while (n >= 400)
            {
                r += "CD";
                n -= 400;
            }
            while (n >= 100)
            {
                r += "C";
                n -= 100;
            }
            while (n >= 90)
            {
                r += "XC";
                n -= 90;
            }
            while (n >= 50)
            {
                r += "L";
                n -= 50;
            }
            while (n >= 40)
            {
                r += "XL";
                n -= 40;
            }
            while (n >= 10)
            {
                r += "X";
                n -= 10;
            }
            while (n >= 9)
            {
                r += "IX";
                n -= 9;
            }
            while (n >= 5)
            {
                r += "V";
                n -= 5;
            }
            while (n >= 4)
            {
                r += "IV";
                n -= 4;
            }
            while (n >= 1)
            {
                r += "I";
                n--;
            }
            return r;
        }

        static int FromRoman(string r)
        {
            var d = 1;//one or two digits?
            int n = 0;
            Dictionary<string, int> RtoN = new Dictionary<string, int>() { { "I", 1 }, { "IV", 4 }, { "V", 5 }, { "IX", 9 }, { "X", 10 }, { "XL", 40 }, { "L", 50 }, { "XC", 90 }, { "C", 100 }, { "CD", 400 }, { "D", 500 }, { "CM", 900 }, { "M", 1000 } };
            for (var i = 0; i < r.Length; i += d)
            {
                string c = "";
                bool find = false;
                if (i + 1 < (r.Length))
                {
                    c = r.Substring(i, 2);
                    foreach (var rn in RtoN.Reverse())
                    {
                        if (c == rn.Key)
                        {
                            n += rn.Value;
                            d = rn.Key.Length;
                            find = true;
                        }
                    }
                }
                if (find == false)
                {
                    c = r.Substring(i, 1);
                    foreach (var rn in RtoN.Reverse())
                    {
                        if (c == rn.Key)
                        {
                            n += rn.Value;
                            d = rn.Key.Length;
                            find = true;
                        }
                    }
                }
            }
            return n;
        }
    }
}
