using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myZoo
{
    public class Rottweiler : Dog
    {
        public bool CrestedTail { get; set; }
        public Rottweiler(string specie, string color, int age, int lifeExpectancy, string breed,
            bool crestedTail, bool mammal = true, bool huntingDog = false) 
            : base(specie, color, age, lifeExpectancy, breed, mammal, huntingDog)
        {
            CrestedTail = crestedTail;
        }
        public void Drool()
        {
            Console.WriteLine($"{Breed}en dreglar...");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Breed} skäller högt!");
        }
    }
}
