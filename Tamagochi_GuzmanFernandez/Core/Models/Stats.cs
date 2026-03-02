using System;
using Tamagochi.Core.Models.Enums;

namespace Tamagochi.Core.Models
{
    public class Stats
    {
        public int Hunger { get; set; } = 100;
        public int Energy { get; set; } = 100;
        public int Health { get; set; } = 100;
    }
}
