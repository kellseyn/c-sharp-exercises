//using System;
//using System.Collections.Generic;

//namespace csharpexercises
//{

//    public class FacebookLikes
//    {
//        public FacebookLikes()
//        {
//            var Likes = new List<string>();
//            bool isGoing = true;
//            while (isGoing)
//            {
//                Console.Write("Input a name please: ");
//                int count = Likes.Count;

//                var input = Console.ReadLine();
//                Likes.Add(input);

//                if (input == "")
//                {
//                    if (count > 2)
//                    {
//                        Console.WriteLine("{0} & {1} Liked your post along with {2} others", Likes[0], Likes[1], (count - 2));
//                    }
//                    else if (count == 2)
//                    {
//                        Console.WriteLine("{0} & {1} Liked your post!", Likes[0], Likes[1]);
//                    }
//                    else if (count == 1)
//                    {
//                        Console.WriteLine("{0} Liked your post!", Likes[0]);

//                    }
//                    else
//                    {
//                        Console.WriteLine();
//                    }
//                    isGoing = false;

//                }


//            }
//            Console.Write("Please enter your name: ");
//            var input = Console.ReadLine();

//            var newStr = "";
//            for (var i = 1; i < input.Length; i++)
//            {
//                var temp = input[input.Length - i];
//                newStr += temp;
//            }
//            newStr += input[0];
//            Console.WriteLine(newStr);

//        }



//    }
    
//}
