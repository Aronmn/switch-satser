using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_satser
{
    class Program
    {
        static void Main(string[] args)
        {
            //övning 1

            Console.WriteLine("Skriv in ett hel tal");

            int tal = int.Parse(Console.ReadLine());
            

            switch (tal)
            {
                case 1:
                    Console.WriteLine("Ett");
                    break;
                case 2:
                    Console.WriteLine("Två");
                    break;
                case 3:
                    Console.WriteLine("Tre");
                    break;
                case 4:
                    Console.WriteLine("Fyra");
                    break;
                default:
                    Console.WriteLine("Ogilitigt alternativ");
                    break;
            }
        }
    }
}
