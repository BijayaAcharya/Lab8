using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            



                Console.WriteLine(" Welcome to C# Class! Which student would you like to learn more about? Enter a number 1-9.");
                string input = (Console.ReadLine());

            while (true)
            {

            
                // creating arrays and storing the names
                string[] names = new string[10] { "David", "Bob", "Leon", "Adam", "Mat", "Lavid", "Chris", "Leoen", "Ada", "Patric" };

                string[] favfood = new string[10] { "Sandwich", "Taco", "Mac n Cheese", "pasta", "spagetti", "Sandwich", "Taco", "Mac n Cheese", "pasta", "spagetti" };

                string[] hometown = new string[10] { "Detroit", "Canton", "Novi", "Southfield", "Troy", "Detroit", "Canton", "Novi", "Southfield", "Troy" };

                bool loopBool = true;


                while (loopBool)
                {


                    if (Regex.IsMatch(input, @"^\d{1}$")) //validating input
                    {

                        Console.WriteLine($"This is {names[Convert.ToInt32(input)]}! What would you like to know about {names[Convert.ToInt32(input)]}?");
                        loopBool = false;
                    }

                    else
                    {
                        Console.WriteLine("That student doesn't exist. Please try again.Please enter a number between 1-9!");
                        input = Console.ReadLine();
                    }

                }

                loopBool = true;
                string info = "";

                
                
               
                    Console.WriteLine($"Would you like to know about {names[Convert.ToInt32(input)]}'s hometown or food? Please print the word!");
                    info = Console.ReadLine();

                    if (Regex.IsMatch(info, @"^hometown$"))
                    {

                        Console.WriteLine($"This is {names[Convert.ToInt32(input)]}! He is from {hometown[Convert.ToInt32(input)]}");


                    }


                    else if (Regex.IsMatch(info, @"^food$"))
                    {
                        Console.WriteLine($"This is {names[Convert.ToInt32(input)]}! His fav food is {favfood[Convert.ToInt32(input)]}");

                    }
                    else if (info == "n")
                    {
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Pleaes print food or hometown!");
                        
                    }

                
                    Console.WriteLine("Do you want to continue?, 'y/n'"); // asking user input

                    string asnwer = Console.ReadLine().ToLower(); // reading from the console and converting user input into lower case

                    if (asnwer == "n")
                    {
                     break;

                    }
                    else
                    {
                        continue;
                        

                    }
                   

                    
            }
           
        }
    }
}





    


        
        
    
