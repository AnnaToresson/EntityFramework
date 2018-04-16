using System;

namespace EfSamurai.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
