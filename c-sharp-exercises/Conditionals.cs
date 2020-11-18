using System;

namespace csharpexercises
{
    public class Conditionals
    {
        public void Exercise1()
        {
            Console.Write("Enter a number between 1 and 20: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if(number >= 1 && number <= 20)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }

        public void Exercise2()
        {
            Console.Write("Enter a number");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);
        }

        public void Exercise3()
        {
            Console.WriteLine("Width is: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Height is: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? "Landscape" : "Portrait";
            Console.WriteLine("Image orientation is " + orientation);
        }

        public void Exercise4()
        {
            Console.Write("What is the speed limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car?");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if(carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if(demeritPoints > 12)
                {
                    Console.WriteLine("License suspended");
                } else
                {
                    Console.WriteLine("Demerit points: " + demeritPoints);
                }
            }
        }
    }
}
