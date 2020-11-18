using System;

namespace csharpexercises
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; private set; }


        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public string FirstName;
        public string LastName;


        public int Age
        {
            get
                {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
                }
        }

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
