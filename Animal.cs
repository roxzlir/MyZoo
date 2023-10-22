using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myZoo
{
    public abstract class Animal
    {
        public string Specie { get; }
        public string Color { get; }
        public int Age { get; set; }
        public int LifeExpectancy { get; }
        public bool Mammal { get; }

      
        public Animal(string specie, string color, int age, int lifeExpectancy, bool mammal=true)
        {
            Specie = specie;
            Color = color;
            Age = age;
            LifeExpectancy = lifeExpectancy;
            Mammal = mammal;
        }
       

        public abstract void MakeSound();

        public void Eating(string typeOfFood = "")
        {
            Console.WriteLine($"{Specie} äter {typeOfFood}");
        }
        public void Sleeps()
        {
            Console.WriteLine($"Nu sover {Specie}en");
        }
      

    }
}
