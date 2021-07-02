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

    class Armor
    {
        private ArmorType _armorType;
        private float _defense;
        
        public Armor(ArmorType armorType, float defense)
        {
            _armorType = armorType;
            _defense = defense;
        }
    }
}
