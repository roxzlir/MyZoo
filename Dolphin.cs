using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myZoo
{
    public class Dolphin : Fish 
    {
        public bool LiveFree { get; set; }
        public Dolphin(string specie, string color, int age, int lifeExpectancy, string typeOfFish, 
            bool liveFree = true, bool mammal = false, bool liveInSaltWater = false) 
            : base(specie, color, age, lifeExpectancy, typeOfFish, mammal, liveInSaltWater)
        {
            LiveFree = liveFree;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{TypeOfFish} låter eeeak eaak");
        }
        public void Jump(bool High=false)
        {
            if (High)
            {
                Console.WriteLine($"{TypeOfFish}en hoppar högt upp ur vattnet och gör en volt!");
            }
            else
            {
                Console.WriteLine($"{TypeOfFish}en hoppar precis upp ovanför vattenytan och ner igen.");
            }
            
        }
    }
}
