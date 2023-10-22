using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myZoo
{
    public abstract class Dog : Animal
    {
        public bool HuntingDog { get; set; }
        public string Breed { get; }
        protected Dog(string specie, string color, int age, int lifeExpectancy, string breed,
            bool mammal = true, bool huntingDog = false) : base(specie, color, age, lifeExpectancy, mammal)
        {
            Breed = breed;
            HuntingDog = huntingDog;
        }
        public void JumpingOfHappines()
        {
            Console.WriteLine($"{Breed}en brukar hoppa glatt när du kommer hem till den,");
            if (HuntingDog)
            {
                Console.WriteLine($"visste du att just rasen {Breed} är känd för att vara bra som jakthund.");
            }
            else
            {
                Console.WriteLine($"letar du jakt hund är inte rasen {Breed} så lämpad för dig.");
            }
        }
    }
}
