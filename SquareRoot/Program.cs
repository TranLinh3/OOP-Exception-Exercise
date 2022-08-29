using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a =
            Convert.ToInt16(Console.ReadLine());
            try
            {

                if (a < 0)
                {
                    throw new Exception();
                }
                else
                {
                    double b = Math.Sqrt(a);
                    Console.WriteLine(Math.Sqrt(a));
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
            Console.ReadKey();

        }
    }
}