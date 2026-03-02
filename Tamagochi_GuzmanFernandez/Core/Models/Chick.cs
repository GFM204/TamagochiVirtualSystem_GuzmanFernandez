using System;
using System.Xml.Linq;


namespace Tamagochi.Core.Models
{
    public class Chick : Pet
    {
        private const string DefaultSound = "says: Pio Pio";
        public override void MakeSound()
        {
            Console.WriteLine(Sound);
        }
        public Chick(string name) : base(name, DefaultSound) { }

        public void Fly()
        {
            Console.WriteLine($"Is {Name} flying ?? Now it don't :(");
        }
    }
}
