using System;
using System.Collections.Generic;
using System.Text;

namespace DownBelow
{
    public enum WeaponType
    {
        Sword,
        Dagger,
        Axe,
        Bow
    }

    class Weapon : Item
    {
        public WeaponType WeaponType { get; private set; }
        public float Damage { get; private set; }

        public Weapon(WeaponType weaponType, float damage, string name) : base(name)
        {
            WeaponType = weaponType;
            Damage = damage;
        }

        public void IncreaseDamage(float damageIncrease)
        {
            Damage += damageIncrease;
        }
    }
}
