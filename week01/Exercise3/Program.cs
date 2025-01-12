using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //string userInput = Console.ReadLine();
        //int magicNumber = int.Parse(userInput);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                break; // Exits the loop 
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("Lower");
            }

        } while (guess != magicNumber);
    }
}