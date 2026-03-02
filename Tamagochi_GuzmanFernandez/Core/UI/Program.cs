using System;
using Tamagochi.Core.Models;
using Tamagochi.Core.Models.Enums;

namespace Tamagochi.Core.UI
{
    public class Activity
    {
        public static void Main()
        {
            Food food1 = new Food(20.5f, TypeFood.Snack, "Potatos");
            Food food2 = new Food(30.5f, TypeFood.Snack);

            Console.WriteLine(food1.ToString());
            Console.WriteLine(food2.ToString());


            Dog myDog = new Dog("Cobby");
            Cat myCat = new Cat("Indiana");
            Console.WriteLine(myCat.ToString());
            Console.WriteLine(myDog.ToString());
        }
    }
}