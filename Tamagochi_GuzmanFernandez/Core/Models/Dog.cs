using System;
using Tamagochi.Core.Interfaces;
using Tamagochi.Core.Models.Enums;


namespace Tamagochi.Core.Models
{
    public class Dog : Pet
    {
        private const string DefaultSound = "Says: Wooff";
        public override void MakeSound()
        {
            Console.WriteLine(Sound);
        }
        public Dog(string name) : base(name, DefaultSound) { }

        public void TakeAWalk()
        {
            Console.WriteLine($"You take {Name} for a walk");
        }

    }
}
