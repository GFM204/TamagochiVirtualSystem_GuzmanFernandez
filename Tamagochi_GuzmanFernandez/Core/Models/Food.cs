using System;
using Tamagochi.Core.Models.Enums;

namespace Tamagochi.Core.Models
{
    public class Food : Item
    {
        public const TypeFood DefaultFood = TypeFood.Snack;
        public const float DefaultNutritiveValue = 15.5f;
        public float NutritiveValue { get; set; }
        public TypeFood TypeFood { get; set; }

        public Food (float nutritiveValue,  TypeFood typeFood, string name, string description)
        {
            NutritiveValue = nutritiveValue;
            TypeFood = typeFood;
            Name = name;
            Description = description;
        }
        public Food(float nutritiveValue, TypeFood typeFood, string name) : this (nutritiveValue, typeFood, name, DefaultDescription) {}
        public Food(): this (DefaultNutritiveValue, DefaultFood, DefaultName, DefaultDescription){ }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Nutritive Value: {this.NutritiveValue}");
            Console.WriteLine($"Food Type: {this.TypeFood.ToString()}");
            Console.WriteLine($"Description: {this.Description}");
        }

    }
}
