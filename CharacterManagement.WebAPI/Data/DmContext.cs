using CharacterManagement.WebAPI.Models;
using CharacterManagement.WebAPI.Models.Item.Base;
using CharacterManagement.WebAPI.Models.Item.ItemTypes;
using CharacterManagement.WebAPI.Models.Skill;
using CharacterManagement.WebAPI.Models.Skill.Base;
using Microsoft.EntityFrameworkCore;

namespace CharacterManagement.WebAPI.Data
{
    public class DmContext : DbContext
    {
        public DmContext(DbContextOptions<DmContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Effect> Effects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Items");
            modelBuilder.Entity<AttackItem>().ToTable("AttackItems");
            modelBuilder.Entity<AcessoryItem>().ToTable("AcessoryItems");
            modelBuilder.Entity<EquipmentItem>().ToTable("EquipmentItems");
            modelBuilder.Entity<MiscellaneousItem>().ToTable("MiscellaneousItems");
            modelBuilder.Entity<RuneItem>().ToTable("RuneItems");
            modelBuilder.Entity<ToolItem>().ToTable("ToolItems");
        }
    }
}
