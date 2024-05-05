using System.Collections.Generic;

namespace Program
{
    public class Dwarf : ICharacter
    {
        private string name;
        private int health;
        private Dictionary<string, Item> items;

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value < 0)
                {
                    this.health = 0;
                }
                else
                {
                    this.health = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public Dictionary<string, Item> Items
        {
            get
            {
                return this.items;
            }

            set
            {
                this.items = value;
            }
        }

        public Dwarf(string name, int health)
        {
            this.name = name;
            this.health = health;
            this.items = new Dictionary<string, Item>();
        }

        public void Attack(ICharacter enemy)
        {
            if (enemy.CalculateDefense() < CalculateDamage())
            {
                enemy.Health -= CalculateDamage() - enemy.CalculateDefense();
            }
        }

        public void AddItem(Item item)
        {
            this.Items[item.Type] = item;
        }

        public void RemoveItem(Item item)
        {
            this.Items.Remove(item.Type);
        }

        public int CalculateDefense()
        {
            int totalDefense = 0;
            foreach (string item in Items.Keys)
            {
                if (item.Contains("defense"))
                {
                    totalDefense += Items[item].Defense;
                }
            }
            return totalDefense;
        }

        public int CalculateDamage()
        {
            int totalDMG = 0; 
            foreach (string item in Items.Keys)
            {
                if (item.Contains("weapon"))
                {
                    totalDMG += Items[item].Damage;
                }
            }
            return totalDMG; 
        }
    }
}
