namespace CharacterManagement.WebAPI.Models.Item.ItemTypes
{
    public class EquipmentItem : Base.Item
    {
        public int Defense { get; set; }
        public string DefenseType { get; set; }
        public List<Skill.Base.Skill> Skills { get; set; }
    }
}
