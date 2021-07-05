using System;
using System.Collections.Generic;
using System.Text;

namespace DownBelow
{
    public enum ArmorType
    {
        Helmet,
        ChestPiece,
        Pants,
        Boots
    }

    class Armor : Item
    {
        public ArmorType ArmorType { get; private set; }
        public float Defense { get; private set; }
        
        public Armor(ArmorType armorType, float defense, string name) : base(name) 
        {
            ArmorType = armorType;
            Defense = defense;
        }

        public void IncreaseDefense(float defenseIncrease)
        {
            Defense += defenseIncrease;
        }
    }
}
