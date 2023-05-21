namespace CharacterManagement.WebAPI.Models.Item.ItemTypes
{
    public class AcessoryItem : Base.Item
    {
        public int Defense { get; set; }
        public List<Skill.Base.Skill> Skills { get; set; }
    }
}
