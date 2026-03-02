using System;
using Tamagochi.Core.Interfaces;
using Tamagochi.Core.Models.Enums;

namespace Tamagochi.Core.Models
{
    public class Cat : Pet
    {
        private const string DefaultSound = "says: MEAW";
        public override void MakeSound()
        {
            Console.WriteLine(Sound);
        }
        public Cat (string name): base(name, DefaultSound) { }

        public void FurBall()
        {
            Console.WriteLine($"{Name} is doing a furball");
        }

        
    }
}
