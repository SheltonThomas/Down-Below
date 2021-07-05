using System;
using System.Collections.Generic;
using System.Text;

namespace DownBelow
{
    public enum KeyPressed
    {
        Default,
        Up,
        Down,
        Left,
        Right,
        Select,
        Back,
        Exit,
        Invalid
    }
    class Player : GameObject
    {
        private string _name;
        private float _damage;
        private float _health;
        private Inventory _inventory;
        private Vector2 _previousPosition;
        public KeyPressed KeyPressed { get; set; }

        //Add Inventory when class is made
        public Player(int health, int damage, string name, int x, int y, bool hasCollision) : base(x, y, hasCollision, 0, TileType.Player)
        {
            _name = name;
            _damage = damage;
            _health = health;
            _inventory = new Inventory();
            KeyPressed = KeyPressed.Default;
        }

        public float TakeDamage(float damage)
        {
            float damageDelt = damage - _inventory.EquippedArmor.Defense;

            _health -= damageDelt;

            return damageDelt;
        }

        public float GetAttackValue()
        {
            return _damage + _inventory.EquippedWeapon.Damage;
        }

        public float GetHealth()
        {
            return _health;
        }
    }
}
