using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseExample
{
    class Program
    {
        static void Main(string[] args)
        {

            int day ;

            Console.WriteLine("Enter day # :");
            //read and type casting /convert

            day  =Convert.ToInt32(  Console.ReadLine());
            
            switch (day)
            {

                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Other day");
                    break;
            }
            Console.ReadKey();

        }
    }
}
