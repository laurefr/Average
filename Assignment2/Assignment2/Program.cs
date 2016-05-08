using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Average Calculator");
            Console.WriteLine("Type 'A' to add a new number to the list \n ‘V’ for the average \n 'S'to sort the list \n ‘X’ to exit:");

            // Create a List
            List<double> number = new List<double>();


            //Using A char for the program to read the user input character
            char Y = (char)Console.Read();
            char X = (char)Console.Read();


            do
            {


                char UserResponse = Convert.ToChar(Console.ReadLine());

                switch (UserResponse)
                {
                    //
                    case 'A':
                        Console.WriteLine("Would you like to add another number to your list?: (Y/N");
                        // if statement 
                        if (Y == 'y')
                            Console.WriteLine("Please enter a number then press return");
                        else
                        {
                            Console.WriteLine("Type ‘V’ to get the average of the list, ‘S’ to sort it, or ‘X’ to exit:");
                        }
                        break;
                    //Average Extension Method
                    case 'V':
                        {
                            double average = number.Average();
                            Console.WriteLine("The Average number of your list is " + average);
                            Console.WriteLine("Type 'A' to add a new number to the list, ‘S’ to sort it, or ‘X’ to exit:");
                        }
                        break;
                    case 'S':
                        {
                            number.Sort();
                            Console.WriteLine("Type 'A' to add a new number to the list, ‘V’ for the average, or ‘X’ to exit:");
                        }
                        break;

                    default:
                        break;
                }
            }
            while (X == 'X');

      
            }// End Of NameSpace
        }//End Of Main
    }// End Of Program

