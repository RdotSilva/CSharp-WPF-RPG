namespace Engine.Models
{
    public class Weapon
    {
        public class Weapon : GameItem
        {
            public int MinimumDamage { get; set; } 
            public int MaximumDamage { get; set; }

            public Weapon(int itemTypeID, string name, int price, int minDamage, int maxDamage) : base(itemTypeID, name, price)
            {
                MinimumDamage = minDamage;
                MaximumDamage = maxDamage;
            }
        }

    }
}