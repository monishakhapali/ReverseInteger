using System;
using System.Linq;

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 123;
            string r = x.ToString();
            string s = string.Empty;
            for(int i= r.Length; i>=0;i--)
            {
                s = s + r[i];
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
