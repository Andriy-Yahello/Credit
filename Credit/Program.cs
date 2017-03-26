
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 700;

            Console.WriteLine("Please, type amount of money you want to pay. 700 is needed");

            int b = Convert.ToInt32(Console.ReadLine());

            Status(a, b);

            Console.ReadKey();
        }

        static void Status(int a, int c)
        {

            if (c>a){
                Console.WriteLine("You have overpayed {0}", c - a); 
            }else if(c<a) {
                 Console.WriteLine("{0} left to pay", a - c);
            }
            else
            {
                Console.WriteLine("loan repaid");
            }
        }
    }
}
