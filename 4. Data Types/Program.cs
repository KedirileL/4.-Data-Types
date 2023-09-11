using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration of string, an integer, a boolean and a decimal.

            string name = "John";
            int age = 18;
            bool isTall = true;
            double weight = 80.2;
            char initial = 'A';

            //print to console
            Console.WriteLine("His name is " + name + " he is " + age + " it is " + isTall + " that he is tall");
            Console.WriteLine("His weight in Kgs is " + weight + " his initial is " + initial);

            name = "Tim";
            age = 23;
            weight = 30.5;
            initial = 'E';


            Console.WriteLine("His name is " + name + " he is " + age + " it is " + isTall + " that he is tall");
            Console.WriteLine("His weight in Kgs is " + weight + " his initial is " + initial);
        }
    }
}
