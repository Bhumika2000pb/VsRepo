using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to Devops tool with modification");
            show();
            Console.ReadKey();
        }

        static void show()
        {
            Console.WriteLine("show function called");
        }

        public static int square(int n)
        {
            return n * n;
        }
    }
}
