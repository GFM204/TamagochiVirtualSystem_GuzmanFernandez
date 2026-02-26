using System;


namespace Tamagochi.Core.Models
{
    public abstract class Item
    {
        public const string DefaultName = "Turkey";
        public const string DefaultDescription = "Default description";
        protected string Name { get; set; }
        protected string Description { get; set; }

        public abstract void ShowInfo();
    }
}
