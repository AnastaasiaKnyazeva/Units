using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Units
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int test1(int x)
        {
            return x + x;
        }
        public static int test2(int x)
        {
            return x * x;
        }
        public static Boolean test3(int x)
        {
            if (x > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static object test4(int x)
        {
            object Pepka;
            if (x > 0)
            {
                Pepka = x;
                return Pepka;
            }
            else
            {
                Pepka = null;
                return Pepka;
            }
        }

        public static string test5()
        {
            string str = "stroka";
            return str;
        }
        public static void test6()
        {
            List<string> collection = new List<string> { "apple", "banana", "cherry" };
            Console.WriteLine(collection);
        }






    }
}
