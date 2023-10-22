using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myZoo
{
    public class Lion : Cat
    {
        public bool HaveMane { get; }
        public Lion(string specie, string color, int age, int lifeExpectancy, string race, 
            bool haveMane = true, bool mammal = true, bool wild = false) 
            : base(specie, color, age, lifeExpectancy, race, mammal, wild)
        {
            HaveMane = haveMane;
        }
        public void SneakingOnPray()
        {
            Console.WriteLine($"{Race} smyger på en gazell i höggräset...");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Race} ryyyyyter!");
        }
    }
}
