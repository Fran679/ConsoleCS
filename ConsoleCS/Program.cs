using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = Console.ReadLine();
            string hola = "fran";
            while (!name.Contains(hola))
            {
                name = Console.ReadLine();
            }

            Greatings(name);

        }
        private static void Greatings(string name)
        {
            Console.WriteLine("Good Morning " + name);
        }

        private static void Counter()
        {

            int HowManyNumbersAre;
            int NumberToLookFor;
            int HowManyOfThisNumberAre = 0;

            bool writtenNumbers;


            Console.WriteLine("---------------------");
            Console.WriteLine("HOY MANY RANDOM NUMBERS");
            HowManyNumbersAre = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------");

            Console.WriteLine("NUMBER TO LOOK FOR - ");
            NumberToLookFor = Convert.ToInt32(Console.ReadLine());
            while (NumberToLookFor > HowManyNumbersAre)
            {
                Console.WriteLine("NUMBER TO BIG, USE ONE SMALLER THANK..." + HowManyNumbersAre);
                NumberToLookFor = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("---------------------");

            Console.WriteLine("PRINT NUMBERS?  true/false");
            writtenNumbers = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("---------------------");

            int[] NumList = new int[HowManyNumbersAre];
            int[] HowManyOfEachNumb = new int[HowManyNumbersAre];

            Random rnd = new Random();


            foreach (int k in NumList)
            {
                NumList[k] = rnd.Next(0, HowManyNumbersAre);
                if (writtenNumbers)
                {
                    if (NumList[k].Equals(NumberToLookFor))
                    {
                        HowManyOfThisNumberAre++;
                        Console.WriteLine(NumList[k] + "<----------------------");
                    }
                    else
                        Console.WriteLine(NumList[k]);
                }
                else
                    continue;
            }


            Console.WriteLine("there Are" + " " + HowManyOfThisNumberAre + " " + "instances of the number" + " " + NumberToLookFor);
        }

    }

}
