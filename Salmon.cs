using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myZoo
{
    public class Salmon : Fish
    {

        public Salmon(string specie, string color, int age, int lifeExpectancy, string typeOfFish,
            bool mammal = false, bool liveInSaltWater = false) 
            : base(specie, color, age, lifeExpectancy, typeOfFish, mammal, liveInSaltWater)
        {
        }
        public void Swim(bool upStream)
        {
            if (upStream)
            {
                Console.WriteLine("Laxen simmar uppströms i bäcken!");
            }
            else
            {
                Console.WriteLine("Laxen simmar med strömmen");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{TypeOfFish} säger blubb");
        }

    }
}
