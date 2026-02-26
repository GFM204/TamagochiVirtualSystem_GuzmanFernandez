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
            Food food2 = new Food();

            food1.ShowInfo();
            food2.ShowInfo();
        }
    }
}