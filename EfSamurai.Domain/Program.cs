using System;
using System.Collections.Generic;

namespace EfSamurai.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> ListOfQuotes { get; set; }
        public string HairStyle { get; set; }
        public string SecretIdentity { get; set; }
        
    }  
        
}
