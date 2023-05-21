namespace CharacterManagement.WebAPI.Models.Item.ItemTypes
{
    public class RuneItem : Base.Item
    {
        public int Charges { get; set; }
        public List<Skill.Base.Skill> Skills { get; set; }
    }
}
