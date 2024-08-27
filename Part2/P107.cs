using System;
using System.Collections;
using System.Collections.Generic;

namespace P107
{
    class Artists : IComparable
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Birth { get; set; }
        public int Die {  get; set; }

        public Artists(string name, string country, int birth, int die)
        { Name = name; Country = country; Birth = birth; Die = die; }

        public int CompareTo(object obj)
        {
            Artists a = (Artists)obj;
            return this.Birth.CompareTo(a.Birth);
        }

        public override string ToString()
        {
            return string.Format($" {Name}, {Country}, {Birth}, {Die}");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Artists[] artists =
            {
                new Artists("A", "a", 1452, 1519),
                new Artists("B", "b", 1853, 1890),
                new Artists("C", "C", 1840, 1926),
                new Artists("D", "d", 1430, 1490),
                new Artists("E", "e", 1460, 1520)
            };

            foreach (Artists value in artists)
            {
                Console.WriteLine(value.ToString());
            }
            Console.WriteLine();

            List<Artists> artist15c = new List<Artists>();
            foreach (Artists artist in artists)
            {
                if (artist.Birth > 1400 && artist.Birth < 1500)
                    artist15c.Add(artist);
            }

            artist15c.Sort();
            foreach (Artists artist in artist15c)
            {
                Console.WriteLine(artist.ToString());
            }
        }
    }
}
