using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zhibin_Yu_8703907_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize the length and width of the rectangle
            int length = 0;
            int width = 0;

            //get length of rectangle
            while (true)
            {
                Console.Write("Please input the length of the rectangle: ");
                string input = Console.ReadLine();
                //input should be integer and greater than 0
                if (Regex.IsMatch(input, "^[0-9]*$")&&int.Parse(input)>0)
                {
                    length=int.Parse(input);
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input! Input should be integer and greater than 0. Please try again.");
                }
            }

            //get width of rectangle
            while (true)
            {
                Console.Write("Please input the width of the rectangle: ");
                string input = Console.ReadLine();
                //input should be integer and greater than 0
                if (Regex.IsMatch(input, "^[0-9]*$") && int.Parse(input) > 0)
                {
                    width=int.Parse(input);
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input! Input should be integer and greater than 0. Please try again.");
                }
            }

            //initialize the rectangle with the length and width input by user
            Rectangle rectangle = new Rectangle(length,width);
            Console.WriteLine("Rectangle initialzed!");

            //show menu
            while (true)
            {
                Console.Write(" 1. Get Rectangle Length \n 2.Change Rectangle Length \n 3.Get Rectangle Width \n 4.Change Rectangle Width \n 5.Get Rectangle Perimeter \n 6.Get Rectangle Area \n 7.Exit \nPlease input your choice: ");
                string input = Console.ReadLine();
                if(Regex.IsMatch(input, "^[0-9]*$"))
                {
                    switch (int.Parse(input))
                    {
                        case 1:
                            Console.WriteLine(rectangle.GetLength());
                            continue;

                        case 2:
                            while (true)
                            {
                                Console.Write("Please input the length of the rectangle: ");
                                string input1 = Console.ReadLine();
                                //input should be integer and greater than 1
                                if (Regex.IsMatch(input1, "^[0-9]*$") && int.Parse(input1) > 1)
                                {
                                    rectangle.SetLength(int.Parse(input1));
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong input! Input should be integer and greater than 1. Please try again.");
                                }
                            }
                            continue;

                        case 3:
                            Console.WriteLine(rectangle.GetWidth());
                            continue;

                        case 4:
                            while (true)
                            {
                                Console.Write("Please input the width of the rectangle: ");
                                string input1 = Console.ReadLine();
                                //input should be integer and greater than 1
                                if (Regex.IsMatch(input1, "^[0-9]*$") && int.Parse(input1) > 1)
                                {
                                    rectangle.SetWidth(int.Parse(input1));
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong input! Input should be integer and greater than 1. Please try again.");
                                }
                            }
                            continue;

                        case 5:
                            Console.WriteLine(rectangle.GetPerimeter());
                            continue;

                        case 6:
                            Console.WriteLine(rectangle.GetArea());
                            continue;

                        case 7:

                            break;

                        default:
                            Console.WriteLine("Wrong input! Input should be integer and from 1 to 7. Please try again.");
                            continue;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input! Input should be integer and from 1 to 7. Please try again.");
                }
            }
        }
    }
}
