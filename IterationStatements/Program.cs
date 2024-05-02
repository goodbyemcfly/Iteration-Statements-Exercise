namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section:

        // Method #1 - Write a method that will print to the console all numbers 1000 through - 1000 - DONE
        static void ListNumbers(int number)
        {
            while (number < 100)
            {
                number++;
                Console.WriteLine(number);
            }
        }
        //Method #2 - Write a method that will print to the console numbers 3 through 999 by 3 each time - DONE
        static void ListByThree(int number)
        {
            while ( number < 999)
            {
                number += 3;
                Console.WriteLine(number);
            }
        }
        // Method #3 - Write a method to accept two integers as parameterss and check whether they are equal or not - DONE
        static void AreTheyEqual(int userInput1, int userInput2)
        {
            if (userInput1 == userInput2)
            {
                Console.WriteLine($"{userInput1} DOES equal {userInput2}");
            }
            else
            {
                 Console.WriteLine($"{userInput1} DOES NOT equal {userInput2}");
            }
        }
        // Method #4 - Write a method to check whether a given number is even or odd - DONE
        static void EvenOrOdd(decimal userInput)
        {
            if (userInput % 2 == 0)
            {
                Console.WriteLine($"{userInput} is an even number");
            }
            else
            {
                Console.WriteLine($"{userInput} is NOT an even number");
            }
        }
        // Method #5 - Write a method to check whether a given number is positive or negative - DONE
        static void PositiveOrNegatvie(int userInput3)
        {
            if (userInput3 < 0)
            {
                Console.WriteLine($"{userInput3} is NEGATIVE number.");
            }
            else
            {
                Console.WriteLine($"{userInput3} is a POSITIVE number.");
            }
        }
        // Method #6 - Write a method to read the age of a candidate and determine whether they can vote. - DONE
        static void CanYouVote(int userAge)
        {
            if (userAge < 18)
            {
                int yearsLeft = 18 - userAge;
                Console.WriteLine($"Sorry, you are not old enough to vote yet. Check back in {yearsLeft} years.");
            }
            else
            {
                Console.WriteLine("Congratulations! You are old enough to vote!");
            }
        }
        //Heatin Up Section:

        // Method #7 - Write a method to check if an integer(from the user) is in the range -10 to 10
        static void BetweenTenAndNegativeTen(int userInt)
        {
            if (userInt < 11 &&  userInt > -11)
            {
                Console.WriteLine("The number you have chosen IS between 10 and -10!");
            }
            else
            {
                Console.WriteLine("Sorry, the number you have chosen is NOT between 10 and -10");
            }
        }
        // Method #8 - Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void MultiplicationTable(int userNumber)
        {
            int multiplyBy = 1;
            while (multiplyBy <= 12)
            {
                Console.WriteLine($"{userNumber} x {multiplyBy} = " + userNumber * multiplyBy);
                multiplyBy++;
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //LukeWarm Section:

            // Method #1
            int number = 0;
            Console.WriteLine("This method will list the numbers 1 - 100");
            ListNumbers(number);

            // Method #2
            number = 0;
            Console.WriteLine("This method will list the numbers 3 - 999 by 3's");
            ListByThree(number);

            // Method #3
            Console.WriteLine("This method will test if two numbers are equal. Please enter the first number");
            var userInput1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            var userInput2 = int.Parse(Console.ReadLine());

            AreTheyEqual(userInput1, userInput2);

            // Method #4
            Console.WriteLine("This method will test if a number is odd or even. Please enter a number");
            var userInput = Convert.ToDecimal(Console.ReadLine());
            EvenOrOdd(userInput);

            // Method #5
            Console.WriteLine("This method will test if a number is positive or negative. Please enter a number");
            var userInput3 = int.Parse(Console.ReadLine());
            PositiveOrNegatvie(userInput3);

            // Method #6
            Console.WriteLine("This method will test if you are old enough to vote. Please enter your age");
            var userAge = int.Parse(Console.ReadLine());
            CanYouVote(userAge);

            // Heatin' Up Section:

            // Method #7 
            Console.WriteLine("This method will test if a number is between 10 and -10. Please enter a number.");
            int userInt = int.Parse(Console.ReadLine());
            BetweenTenAndNegativeTen(userInt);

            // Method #8
            Console.WriteLine("This method will give you the multiplication table of any given number. Please enter a number below.");
            int userNumber = int.Parse(Console.ReadLine());
            MultiplicationTable(userNumber);
        }
    }
}
