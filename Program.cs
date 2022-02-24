using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanitize2
{
    internal class Program
    {
        public static string removechar(string str,int n)
        {
            return str.Remove(n, 1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string:");
            Console.WriteLine(removechar("c#.net", 2));
            Console.ReadLine();

        }
    }
}
