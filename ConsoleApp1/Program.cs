using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool startgame = false;
            while (true)
            {
                try
                {
                    Console.WriteLine("Hello there handsome! \n Choose an option: \n 1. Start!\n 2.Exit :'(");
                    string answer = Console.ReadLine();
                    if ((Convert.ToInt32(answer) == 1))
                    {
                        Console.WriteLine("Lets go!");
                        startgame = true;
                        break;
                    }
                    if ((Convert.ToInt32(answer) == 2))
                    {
                        Console.WriteLine("Ohh... Good bye D:");
                        startgame = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Answer! Try again!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Answer! Try again!");
                }
                catch(ArgumentNullException)
                {
                    Console.WriteLine("Invalid Answer! Try again!");
                }
            }
            if (startgame == false)
            {

            }
            else
            {
                bool gameOver = false;
                while (gameOver == false)
                {
                    Console.WriteLine("You find yourself in a dark dank cave!");
                }
            }
        }
    }
}
