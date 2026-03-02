using System;
using Tamagochi.Core.Models.Enums;

namespace Tamagochi.Core.Models
{
    public abstract class Pet
    {
        public Stats Stats { get; set; } = new Stats();
        public string Name { get; set; }
        public Emotions Emotion { get; set; } = Emotions.Happy;
        public int SnacksEaten { get; set; } = 0;
        public string Sound { get; set; }

        public Pet(string name, string sound)
        {
            Name = name;
            Sound = sound;
            Stats.Energy = 100;
            Stats.Hunger = 100;
            Stats.Health = 100;
        }

        public abstract void MakeSound();
        public override string ToString()
        {
            return $"Name:{Name}   Animic State: {Emotion}   Snacks Eaten: {SnacksEaten}   Sound: {Sound}   Energy: {Stats.Energy}  Hunger: {Stats.Hunger}  Health: {Stats.Health}";
        }
    }
}
