using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello my name is amy");
            string welcomenote=Console.ReadLine();
            Console.WriteLine(welcomenote);
            Console.Clear();
            Console.WriteLine("enter first number");
            int firstnumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            int sum = firstnumber + secondnumber;
            Console.WriteLine("sum of given two number is" + sum);

            float mobleNo = 999999989;
            Console.WriteLine(mobleNo);

            Console.WriteLine("do you want to die???? , if yes press P");
            char a = Console.ReadLine()[0];
            bool quit = false;
            if (a == "P"[0]) ;
            {
                quit = true;
            }
            if (quit == false)
            {
                Console.ReadKey();
            }
            string myName = " Amy Amatya";
            Console.WriteLine(myName.ToLower());
            Console.WriteLine(myName.ToUpper());
            Console.Read();
        }
    }
}
