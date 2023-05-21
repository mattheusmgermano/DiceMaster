namespace CharacterManagement.WebAPI.Models.Item.ItemTypes
{
    public class AttackItem : Base.Item
    {
        public int Damage { get; set; }
        public string DamageType { get; set; }
        public List<Skill.Base.Skill> Skills { get; set; }

    }
}
