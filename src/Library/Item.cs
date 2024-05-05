namespace Program
{
    public class Item
    {

        public string Name {get;set;}
        public int Damage {get;set;}
        public int Defense {get;set;}
        public string Type {get;set;}
        public Item(string name, int damage, int defense, string type)
        {

            this.Name = name;
            this.Damage = damage;
            this.Defense = defense;
            this.Type = type;

        }
    }
}