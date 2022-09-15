using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess the correct number!");
            Console.WriteLine("What is the upper limit for the range of the number!");


            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("Input your guess");

            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Your guess is too high! Sorry");
            }
            else if (guess < number)
            {
                Console.WriteLine("Your guess is too low! Sorry");
            }
            else
            {
                Console.WriteLine("Correct!");
            }


            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is awesome");
                    break;
                case "Science":
                    Console.WriteLine("Science is tough!");
                    break;
                case "English":
                    Console.WriteLine("English is easy!");
                    break;
                default:
                    Console.WriteLine("Ah I haven't taken that subject before");
                    break;
            }

        }
    }
}

