using System.Collections.Generic;
using csharpexercises.Math;
using System;
namespace csharpexercises
{
    partial class MainClass
    {

        public static void Main(string[] args)
        {


           //DateTime and overloading
            var person = new Person(new DateTime(1994, 12, 16));
            Console.WriteLine(person.Age);

            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            Console.WriteLine("point is at ({0}, {1})", point.X, point.Y);

            var peepo = new Peepo(5, "kells");

            var order = new Order();
            peepo.Orders.Add(order);
            Console.WriteLine(peepo.Id);
            Console.WriteLine(peepo.Name);

            var calculator = new Calculator();

            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 7 }));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));

            var peep = Peepo.Parse("Kellsey");
            peep.Introduce("Zack");

            //Lists
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("index of: " + numbers.IndexOf(1));
            Console.WriteLine("last index of: " + numbers.LastIndexOf(1));


            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
                Console.WriteLine(numbers[i]);
            }

            //arrays
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };
            //Length
            Console.WriteLine("Length " + numbers.Length);


            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index " + index);


            //Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of clear");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Copy()

            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("effect of copy ");
            foreach (var a in another)
            {
                Console.WriteLine(a);
            }

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("effect of sort ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of reverse");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }


            //random class
            var random = new Random();
            var buffer = new char[10];

            for (var i = 0; i < 10; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));

                //var password = "";

            }
            var password = new string(buffer);

            Console.WriteLine(password);




            //Console.WriteLine((int)'a');

            //conditionals

            //int hour = 10;

            //if(hour > 0 && hour < 12)
            //{
            //    Console.WriteLine("It's morning.");
            //} else if(hour > 12 && hour < 18)
            //{
            //    Console.WriteLine("It's afternoon");
            //} else
            //{
            //    Console.WriteLine("It's evening");
            //}

            //bool isGoldCustomer = true;

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);

            //var season = Season.Autumn;

            //switch (season)
            //{
            //    case Season.Autumn:
            //        Console.WriteLine("It's fall y'all");
            //        break;

            //    case Season.Summer:
            //        Console.WriteLine("It's summer y'all");
            //        break;

            //    case Season.Winter:
            //        Console.WriteLine("It's winter y'all");
            //        break;

            //    case Season.Spring:
            //        Console.WriteLine("It's spring y'all");
            //        break;

            //    default:
            //        Console.WriteLine("I don't think that's a season");
            //        break;
            //}

            //for(var i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //var i = 0;
            //while (i < 10)
            //{
            //    if(i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    } 
            //}

            //while (true)
            //{
            //    Console.Write("Type your name: ");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo: " + input);
            //        continue;
            //    }
            //    break;
            //}

            //var name = "Kellsey Neagley";
            ////for(var i = 0; i < name.Length; i++)
            ////{
            ////    Console.WriteLine(name[i]);
            ////}
            //foreach(var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            //var numbers = new int[] { 1, 2, 3, 4 };

            //foreach(var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}





            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //} else
            //{
            //    price = 29.95f;
            //}




            //            //enum practice
            //            var method = ShippingMethod.Express;
            //            Console.WriteLine((int)method);

            //            var methodId = 3;
            //            Console.WriteLine((ShippingMethod)methodId);

            //            Console.WriteLine(method.ToString());
            //            var methodName = "Express";
            //            var shippingMethod = Enum.Parse(typeof(ShippingMethod), methodName);
            //            Console.WriteLine(shippingMethod);

            //            //class practice
            //            var kellsey = new Person
            //            {
            //                FirstName = "Kellsey",
            //                LastName = "Neagley"
            //            };
            //            kellsey.Introduce();

            //            Calculator calculator = new Calculator();
            //            var result = calculator.Add(1, 2);
            //            Console.WriteLine(result);


            //            //Arrays
            //            var numbers = new int[3];
            //            numbers[0] = 1;

            //            Console.WriteLine(numbers[0]);
            //            Console.WriteLine(numbers[1]);
            //            Console.WriteLine(numbers[2]);

            //            var flags = new bool[3];
            //            flags[0] = true;

            //            Console.WriteLine(flags[0]);
            //            Console.WriteLine(flags[1]);
            //            Console.WriteLine(flags[2]);

            //            //concat strings and formatting

            //            var firstName = "Kellsey";
            //            var lastName = "Neagley";

            //            var fullName = firstName + " " + lastName;

            //            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            //            var names = new string[3] { "John", "Jack", "Mary" };
            //            var formattedName = string.Join(",", names);
            //            Console.WriteLine(formattedName);


            //            var text = @"Hi John
            //Look into the following paths
            //c:\folder1\folder2
            //c:\folder3\folder4";
            //            Console.WriteLine(text);

            //            //interchangable with var that will automatically note it as the appropriate datatype
            //            var number = 2;
            //            int count = 10;
            //            float totalPrice = 20.95f;
            //            char character = 'A';
            //            bool isCool = true;

            //            Console.WriteLine(number);
            //            Console.WriteLine(count);
            //            Console.WriteLine(totalPrice);
            //            Console.WriteLine(character);
            //            Console.WriteLine(isCool);
            //            Console.WriteLine("testing string");

            //            //formatted string
            //            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //            const float Pi = 3.14f;
            //            Console.WriteLine(Pi);

            //            //type conversion
            //            byte b = 1;
            //            int i = b;
            //            Console.WriteLine(i);

            //            //parsing
            //            int j = 200;
            //            byte c = (byte)j;
            //            Console.WriteLine(c);

            //            //convert

            //            try
            //            {
            //                var num = "1234";
            //                int k = Convert.ToByte(num);
            //                Console.WriteLine(k);

            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine("The number could not be converted to a byte");
            //            }

            //            try
            //            {
            //                string str = "true";
            //                bool d = Convert.ToBoolean(str);
            //                Console.WriteLine(d);
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine("The string could not be converted to a boolean");

            //            }

            //            //operators

            //            var n = 10;
            //            var m = 3;

            //            Console.WriteLine(n / m);
            //            Console.WriteLine(n * m);
            //            Console.WriteLine(n + m);
            //            Console.WriteLine(n - m);
            //            Console.WriteLine(n > m);
            //            Console.WriteLine(n < m);
            //            Console.WriteLine(n != m);
            //            Console.WriteLine(n == m);


            //            //reference type vs value types
            //            var o = 10;
            //            var p = o;
            //            p++;
            //            Console.WriteLine(string.Format("o: {0}, p: {1}", o, p));

            //            var array1 = new int[3] { 1, 2, 3 };
            //            var array2 = array1;
            //            array2[0] = 0;
            //            Console.WriteLine("array[0]: {0}, array2[0]: {1}", array1[0], array2[0]);


            //            var s = 1;
            //            Increment(s);
            //            Console.WriteLine(s);

            //            var peepo = new Person() { Age = 20 };
            //            MakeOld(peepo);
            //            Console.WriteLine(peepo.Age);
            //        }

            //        public static void Increment(int s)
            //        {
            //            s += 10;
            //        }

            //        public static void MakeOld(Person person)
            //        {
            //            person.Age += 10;
        }


    }
}
