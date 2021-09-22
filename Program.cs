using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_Console_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;



            Console.WriteLine("How old are you, In numbers.");
            

         if (Int32.TryParse(Console.ReadLine(), out age));
            {


                if (age > 18)
                {
                    Console.WriteLine("You are an Adult");
                }

                else if (age <= 0)
                {
                    Console.WriteLine("You aren't a fetus.");
                }

                else if (age <= 5)
                {
                    Console.WriteLine("You are a Child.");
                }

                else if (age <= 10)
                {
                    Console.WriteLine("You are a Preteen.");
                }

                else if (age <= 18)
                {
                    Console.WriteLine("You are a Teenager.");
                }

            }

            Console.ReadLine();


        }
    }
}
