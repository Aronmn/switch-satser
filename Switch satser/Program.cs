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

            Console.WriteLine("Skriv in ett heltal");
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

            //Övning 2

            Console.WriteLine("Ange ett vädersträck: N,S,E,W");
            string streck = Console.ReadLine();
            char x = char.Parse(streck);

            switch (x)
            {
                case 'N':
                case 'n':
                    Console.WriteLine("You walk north");
                    break;
                case 'S':
                case 's':
                    Console.WriteLine("You travel south");
                    break;
                case 'E':
                case 'e':
                    Console.WriteLine("You wander east");
                    break;
                case 'W':
                case 'w':
                    Console.WriteLine("You stroll west");
                    break;
                default:
                    Console.WriteLine("I don't understand!");
                    break;
            }
        }
    }
}
