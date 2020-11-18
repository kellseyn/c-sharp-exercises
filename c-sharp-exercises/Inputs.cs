using System;
namespace csharpexercises
{
    public class Inputs
    {
        public Inputs()
        {
            int count = 0;
            for (var i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number, (or 'ok' to exit):");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("The total is: " + sum);


            var guesses = 0;
            var random = new Random();
            var secretNum = random.Next(1, 10);

            Console.WriteLine(secretNum);
            while (guesses < 4)
            {
                Console.Write("Guess a number 1 - 10: ");

                var input = Convert.ToInt32(Console.ReadLine());
                if (input == secretNum)
                {
                    Console.WriteLine("You guessed it! {0}, was the right number", secretNum);
                    break;
                }
                else
                {
                    guesses++;
                }
            }
        }
    }
}
