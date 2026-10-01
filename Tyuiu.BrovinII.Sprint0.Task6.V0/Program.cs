using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BrovinII.Sprint0.Task6.V0.Lib;

namespace Tyuiu.BrovinII.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(DataService.AdditionArray(arraynums));
            Console.WriteLine(DataService.SubstractionArray(arraynums));
            Console.WriteLine(DataService.MultiplicationArray(arraynums));
            Console.ReadKey();
        }
    }
}
