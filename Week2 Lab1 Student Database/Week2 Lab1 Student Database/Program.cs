using System;

namespace Week2_Lab1_Student_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTE - USE either a list OR an array in your program

            //Program has to recognize invalid user inputs when the user requests information about students in a class. 

            //The app provides info about students in a class

            //Prompts the user to ask about a particular student

            //The app gives proper responses according to user-submitted info

            //the app asks if the user would like to learn about another student

  
            bool keepGoing = true;
            while (keepGoing == true)
            { 

                //Declaring the arrays and their elements

                string[] names = { "Andy Beer", "Cortez Christian", "Phillip Conrad", "Cordero Ebberhart", "Cullin Flynn", "Ese Jackson", "Calyn Greene", "Ramone Lynch", "Rick Magdaleno", "Antonio Manzari", "James Mitchell", "Richard Moss", "Marjorie Patton", "Huy Phan", "Anurag Reddy", "Zachary Parr", "Cassly Sullen", "Madalina Varasteanu", "Tommy Waalkes", "Erin Walter" };
                string[] hometown = { "Berkley, Mi", "Detroit, Mi", "Canton, Mi", "Berkley, Mi", "Fowlerville, Mi", "Florida", "Portage, Mi", "Fort Lauderdale, FL", "Gilbert, AZ", "Beverly Hills, Mi", "Yap, FSM", "Canton, Mi", "Detroit, Mi", "Lansing, Mi", "Rochester Hills, Mi", "Wyandotte, Mi", "Detroit, Mi", "Saint Clair Shores, Mi", "Raleigh, NC", "Troy, Mi" };
                string[] favoriteFood = { "French fries", "Chicken Fettuccine Alfredo", "Fried Chicken", "BBQ", "Pad Thai", "Shrimp", "Mac and Cheese", "Chicken Soup", "Hamburger", "Focaccia Barese", "Katsu", "Sushi", "Lasagna", "Koren BBQ", "Tacos", "Sushi", "Steak", "Fries", "Curry", "Tacos" };
           
                Console.WriteLine("Hello! Welcome to our C# Class!");
                Console.WriteLine("Which student would you like to learn more about ? Please enter a number from 1 to 20: ");
                int studentNo = int.Parse(Console.ReadLine()); // Getting user input for which student # they would like to learn about.

                if(!(studentNo >= 1 && studentNo <= 20)) // if the number is not between 1 and 20 then it will tell the user the input was invalid.
                {
                    Console.WriteLine("That student does not exist. Please try again.");
                }
                else
                {
                    Console.WriteLine("Student number " + studentNo + " is " + names[studentNo-1]); //Displaying the number and name of the student then calling an array that has been declared above.
                                                                                                    //between square brackets declaring the number of the element (-1 because computers start counting from 0

                    Console.WriteLine("What would you like to know about " + names[studentNo-1] + " ? Please enter 'hometown' or 'favorite food': ");
                    string userInput = Console.ReadLine().ToLower();
                    string userAnswer;

                    if (userInput == "hometown")
                    {
                        Console.WriteLine(names[studentNo - 1] + " is from " + hometown[studentNo - 1] + ". Would you like to know more? y/n");
                        userAnswer = Console.ReadLine();
                        if(userAnswer == "y")
                        {
                            Console.WriteLine(names[studentNo - 1] + "'s favorite food is " + favoriteFood[studentNo - 1]);
                        }

                    }
                    else if (userInput == "favorite food")
                    {
                        Console.WriteLine(names[studentNo - 1] + "'s favorite food is " + favoriteFood[studentNo - 1] + ". Would you like to know more? y/n");
                        userAnswer = Console.ReadLine();
                        if (userAnswer == "y")
                        {
                            Console.WriteLine(names[studentNo - 1] + " is from " + hometown[studentNo - 1]);
                        }

                    }
                    else
                    {
                        Console.WriteLine("That data does not exist. Please try again.");
                    }

                    keepGoing = Continue();
                }
            }

        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine().ToLower();

            return output;
        }

        public static bool Continue()
        {
            string userInput = GetInput ("Would you like to continue learning about another student? y/n ");
            

            if (userInput == "y")
            {
                return true;
            }
            else if (userInput == "n")
            {
                Console.WriteLine("Thanks");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return Continue();
            }
            
        }
    }
}
