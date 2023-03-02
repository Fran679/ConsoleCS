using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCS
{
    internal class Methods
    {
        static void Main(string[] args)
        {
            string name;
            name = Console.ReadLine();
            
            Greatings(name);

        }
        private static void Greatings(string name)
        {
            Console.WriteLine("Good Morning " + name);
        }

    }

}
