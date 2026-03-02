using System;
using Tamagochi.Core.Models;

namespace Tamagochi.Core.Interfaces
{
    public interface IFood
    {
        //
        public string Eat(Food food);
        public int EatSnack(Food food);
    }
}
