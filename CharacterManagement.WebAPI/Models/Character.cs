namespace CharacterManagement.WebAPI.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Inteligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Level { get; set; }
        public double ExperiencePoints { get; set; }
        public int StatPoints { get; set; }
        public int HealthPoints { get; set; }
        public int MagicPoints { get; set; }
        public List<Item.Base.Item> Inventory { get; set; }
    }
}
