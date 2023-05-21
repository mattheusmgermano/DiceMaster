namespace CharacterManagement.WebAPI.Models.Skill.Base
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SkillType Type { get; set; }
        public int ManaCost { get; set; }
        public int Cooldown { get; set; }
        public int Duration { get; set; }
        public List<Effect> Effects { get; set; }
        public int Damage { get; set; }
        public int HealingPoints { get; set; }
        public int Range { get; set; }

    }

    public enum SkillType
    {
        Offensive,
        Defensive,
        Healing,
        CrowdControl,
        Support,
        Special,
        Function,
    }
}
