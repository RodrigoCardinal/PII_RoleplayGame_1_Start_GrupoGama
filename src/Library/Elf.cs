using System.Collections.Generic;

namespace Program
{
    public class Elf : ICharacter
    {
        private string name;
        private int InitialHealth;
        private int Health;
        private Dictionary<string, Item> items;

        public int Health
        {
            get
            {
                InitialHealth = Health;
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

        public Elf(string name, int health)
        {
            this.name = name;
            this.health = health;
            this.items = new Dictionary<string, Item>();
        }

        public void Attack(ICharacter enemy)
        {
            if (enemy.CalculateDefense() < CalculateDamage())
            {
                enemy.Health -= CalculateDamage(); 
            }
        }

        public void AddItem(Item item)
        {
            this.items[item.Type] = item;
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
            int Totalattack = 0;
            foreach (string item in Items.Keys)
            {
                if (item.Contains("weapon"))
                {
                    Totalattack += Items[item].Damage;
                }
            }
            return Totalattack;
        }
            public void Heal (ICharacter Elf)        
            {       
            if (Elf.Health() < InnitialHealth())
            {
                Elf.Health += CalculateDamage();
            }
            }

    }
}
