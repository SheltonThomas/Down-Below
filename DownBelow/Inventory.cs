﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DownBelow
{
    class Inventory
    {
        private List<Item> _items = new List<Item>();
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }
    }
}
