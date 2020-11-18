using System;
using System.Collections.Generic;

namespace csharpexercises
{
    public class Peepo
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Peepo()
        {
            Orders = new List<Order>();
        }

        public Peepo(int id)
            : this()
        {
            this.Id = id;
        }


        public Peepo(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        //public void Introduce(string to)
        //{
        //    Console.WriteLine("Hi {0}, I am {1}", to, Name);
        //}

        //public static Peepo Parse(string str)
        //{
        //    var peepo = new Peepo();

        //    peepo.Name = str;
        //    return peepo;
        //}
    }
}
