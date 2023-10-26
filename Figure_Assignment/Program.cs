using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Figure_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter figure height : ");
            int height = Convert.ToInt32(Console.ReadLine()); //Enter 10
            Console.WriteLine("Kindly enter figure width : ");
            int width = Convert.ToInt32(Console.ReadLine()); //Enter 10

            for (int a = 0; a < height; a++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                for (int b = 0; b < height; b++)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    for (int c = 0; c < height; c++)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        for (int d = 0; d < height; d++)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;

                            if ((a + c) % 2 == 0)
                            {
                                Console.Write("+ ");
                                Thread.Sleep(10);
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine();
                }
            }


            //ChessBoard below 
            for (int a = 0; a < height; a++)
            {

                for (int b = 0; b < height; b++)
                {

                    for (int c = 0; c < height; c++)
                    {
                        for (int d = 0; d < height; d++)
                        {
                            

                            if ((a + c) % 2 == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.BackgroundColor = ConsoleColor.Gray;
                                Console.Write("+ ");
                                Thread.Sleep(10);
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write("  ");
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }
                Console.ResetColor();
            }
        }
    }
}
