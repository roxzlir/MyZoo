using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myZoo
{
    public abstract class Fish : Animal
    {
        public bool LiveInSaltWater { get; }
        public string TypeOfFish { get; }
        public Fish(string specie, string color, int age, int lifeExpectancy, string typeOfFish,
            bool mammal = false, bool liveInSaltWater = false) 
            : base(specie, color, age, lifeExpectancy, mammal)
        {
            LiveInSaltWater = liveInSaltWater;
            TypeOfFish = typeOfFish;
        }
        public  void DiveDeep()
        {
            Console.WriteLine($"{TypeOfFish}en dyker djupt ner mot botten");
        }

    }
}
