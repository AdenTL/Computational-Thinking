using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_computational_thinking
{
    internal class Exercises
    {
        public static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here
            Console.WriteLine("Enter your first number: ");
            int inputOne = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int inputTwo = Int32.Parse(Console.ReadLine());
           
            if (inputOne != inputTwo)
            {
                Console.WriteLine("The numbers " + inputOne + " and " + inputTwo + " are not equal");
            }
            else
            {
                Console.WriteLine("The numbers " + inputOne + " and " + inputTwo + " are the same number");
            }
            
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here
            Console.WriteLine("Please enter a number: ");
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput % 2 == 0)                                       
            {
                Console.WriteLine(userInput + " is an Even number");
            }
            else
            {
                Console.WriteLine(userInput + " is an Odd number");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here
            Console.WriteLine("Please enter a letter:  ");
            string userInput = Console.ReadLine();
            userInput = userInput.ToUpper();
            switch (userInput)
            {
                case "A":
                    Console.WriteLine("That letter is a Vowel!");
                    break;

                case "E":
                    Console.WriteLine("That letter is a Vowel!");
                    break;

                case "I":
                    Console.WriteLine("That letter is a Vowel!");
                    break;

                case "O":
                    Console.WriteLine("That letter is a Vowel!");
                    break;

                case "U":
                    Console.WriteLine("That letter is a Vowel!");
                    break;

                case "Y":
                    Console.WriteLine("That letter is a Vowel, but only sometimes!");
                    break;
                 default: Console.WriteLine("That letter is a Consonant.");
                    break;
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here
            Console.WriteLine("Please enter your first integer: ");
            int inputOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second integer: ");
            int inputTwo = Int32.Parse(Console.ReadLine());

            if (inputOne > inputTwo)
            {
                Console.WriteLine(inputOne + " is the greatest value integer.");
            }
            else if (inputTwo > inputOne)
            {
                Console.WriteLine(inputTwo + " is the greatest value integer.");
            }
            else
            {
                Console.WriteLine("Please enter two different integers");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here
            Console.WriteLine("Please enter a number: ");
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput % 3 == 0)
            {
                Console.WriteLine(userInput + " is divisible by 3");
            }
            else
            {
                Console.WriteLine(userInput + " is not divisible by 3");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?
            // Use arithmetic operators and print the amount of the total bill to the console.

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.

            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here
            Console.WriteLine("How many people will be dining?");
            float numberOfDiners = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How much did each person pay for dinner?");
            float costPerDiner = Int32.Parse(Console.ReadLine());
           
            float totalBill = costPerDiner * numberOfDiners;
            if (totalBill >= 50)
            {
                float discountTenDifference = (float)(totalBill * .1);
                totalBill -= discountTenDifference;
                Console.WriteLine("You earned a 10% discount from your table's order! Your total bill is $" + totalBill);
            }
            else
            {
                float discountFiveDifference = (float)(totalBill * .05);
                totalBill -= discountFiveDifference;
                Console.WriteLine("You will recieve a 5% discount!" + " Your total bill is $"+ totalBill);
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
            // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");

            // Enter your solution here
            Console.WriteLine("Please enter your age: ");
            int userAge = Int32.Parse(Console.ReadLine());
            if (userAge < 0 || userAge > 100)
            {
                Console.WriteLine("This program is for humans.");
            }
            else if (userAge == 0 || userAge == 1 || userAge == 2)
            {
                Console.WriteLine("Still in Mama's Arms");
            }
            else if (userAge == 3 || userAge == 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (userAge == 5 || userAge == 6 || userAge == 7 || userAge == 8 || userAge == 9 || userAge == 10 || userAge == 11)
            {
                Console.WriteLine("Elementary School");
            }
            else if (userAge == 12 || userAge == 13 || userAge == 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (userAge == 15 || userAge == 16 || userAge == 17 || userAge == 18)
            {
                Console.WriteLine("High School");
            }
            else if (userAge == 19 || userAge == 20 || userAge == 21 || userAge == 22)
            {
                Console.WriteLine("College");
            }
            else if (userAge >= 23 && userAge <= 65 )
            {
                Console.WriteLine("Working for the man");
            }
            else if (userAge >= 66 && userAge <= 100)
            {
                Console.WriteLine("Golden Years");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here
            Console.WriteLine("Please type out a digit 'ZERO' - 'TEN': ");
            string userInput = Console.ReadLine();
            userInput = userInput.ToUpper();
            switch (userInput)
            {
                case "ZERO":
                    Console.WriteLine("0");
                    break;
                case "ONE":
                    Console.WriteLine("1");
                    break;
                case "TWO":
                    Console.WriteLine("2");
                    break;
                case "THREE":
                    Console.WriteLine("3");
                    break;
                case "FOUR":
                    Console.WriteLine("4");
                    break;
                case "FIVE":
                    Console.WriteLine("5");
                    break;
                case "SIX":
                    Console.WriteLine("6");
                    break;
                case "SEVEN":
                    Console.WriteLine("7");
                    break;
                case "EIGHT":
                    Console.WriteLine("8");
                    break;
                case "NINE":
                    Console.WriteLine("9");
                    break;
                case "TEN":
                    Console.WriteLine("10");
                    break;
                    default:
                    Console.WriteLine("Unknown entry, type a digit ONE - TEN");
                    break;
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here
            Console.WriteLine("Please type your First name: ");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Please enter your Last name: ");
            string userLastName = Console.ReadLine();
            Console.WriteLine(userFirstName + " " + userLastName);
            if (userFirstName.Length > userLastName.Length)
            {
                Console.WriteLine("First is longer.");
            }
            else if (userFirstName.Length == userLastName.Length)
            {
                Console.WriteLine("Same-sies");
            }
            else
            {
                Console.WriteLine("Last must be longer");  
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here
            Console.WriteLine("Please enter a name: ");
            string userInputOne = Console.ReadLine();

            Console.WriteLine("Please enter a second name: ");
            string userInputTwo = Console.ReadLine();

            if (userInputOne == userInputTwo)
            {
                Console.WriteLine("The names entered are the same!");
            }
            else
            {
                Console.WriteLine("The names entered and not the same!");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here
            Console.WriteLine("Please enter your first name: ");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Please enter where you were born: ");
            string userBirthPlace = Console.ReadLine();

            Console.WriteLine("Hi " + userFirstName + " you were born in " + userBirthPlace);
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}
