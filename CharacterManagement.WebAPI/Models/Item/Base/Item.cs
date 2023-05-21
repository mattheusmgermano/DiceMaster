using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManagement.WebAPI.Models.Item.Base
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public  ItemType Type { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

    }
    public enum ItemType
    {
        Attack,
        Acessory,
        Equipment,
        Rune,
        Miscellaneous,
        Tool,
        Ammunition,
        Scroll,
    }
}
