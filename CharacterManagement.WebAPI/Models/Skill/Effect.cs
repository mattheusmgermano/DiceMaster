namespace CharacterManagement.WebAPI.Models.Skill
{
    public class Effect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Inteligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int HealthPoints { get; set; }
        public int MagicPoints { get; set; }
    }
}
