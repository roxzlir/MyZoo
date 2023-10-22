using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myZoo
{
    public abstract class Cat : Animal
    {
        public string Race { get; }
        public bool Wild { get; set; }
        protected Cat(string specie, string color, int age, int lifeExpectancy,string race,
            bool mammal = true, bool wild = false) 
            : base(specie, color, age, lifeExpectancy, mammal)
        {
            Race = race;
        }
        public void PurrsOrRoars()
        {
            Console.WriteLine($"{Race}en spinner!");
        }
    }
}
