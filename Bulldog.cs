using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myZoo
{
    public class Bulldog : Dog
    {
        public bool NoTail { get; }

        public Bulldog(string specie, string color, int age, int lifeExpectancy, string race,
            bool mammal = true, bool huntingDog = false,bool noTail = true)
            : base(specie, color, age, lifeExpectancy, race, mammal, huntingDog)
        {
            NoTail = noTail;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Breed} säger voff!"); ;
        }
        public void BulldogSnoor()
        {
            Console.WriteLine("En bulldog snarkar mycket");
        }
    }
}
