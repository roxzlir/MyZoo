using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myZoo
{
    public class Bengal : Cat
    {
        public bool Domestic { get; set; }
        public Bengal(string specie, string color, int age, int lifeExpectancy, string race, 
            bool domestic=true, bool mammal = true, bool wild = false) 
            : base(specie, color, age, lifeExpectancy, race, mammal, wild)
        {
            Domestic = domestic;
        }
       
        public override void MakeSound()
        {
            Console.WriteLine($"{Race} säger mjauu!");
        }
        public void BengalFunInfo()
        {
            Console.WriteLine($"Bengal katter ser ut som en mindre leopard");
        }
    }
}
