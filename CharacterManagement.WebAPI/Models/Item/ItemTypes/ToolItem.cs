namespace CharacterManagement.WebAPI.Models.Item.ItemTypes
{
    public class ToolItem : Base.Item
    {
        public List<Skill.Base.Skill> Skills { get; set; }
    }
}
