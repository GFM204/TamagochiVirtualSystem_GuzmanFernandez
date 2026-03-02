using System;
using Tamagochi.Core.Interfaces;
using Tamagochi.Core.Models.Enums;
using Tamagochi.Core.UI;

namespace Tamagochi.Core.Models
{
    public class Food : AItem
    {
        private float _nutritiveValue;

        private const float DefaultNutritiveValue = 15.5f;
        public float NutritiveValue 
        { 
            get { return _nutritiveValue; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be greater than 0");
                }
                _nutritiveValue = value;
            }
        }
        public TypeFood TypeFood { get; set; }

        public Food (float nutritiveValue,  TypeFood typeFood = TypeFood.Snack, string name = UIConfig.FoodDefaultValues.DefaultName, string description = UIConfig.FoodDefaultValues.DefaultDescription)
        {
            NutritiveValue = nutritiveValue;
            TypeFood = typeFood;
            Name = name;
            Description = description;
        }
        
        public override string ToString() => $"Name: {Name}  Nutritive Value: {NutritiveValue}     Food Type: {TypeFood.ToString()}     Description: {Description}  ";

    }
}
