using System.ComponentModel.DataAnnotations;

namespace MyCvSite.Data
{
    // Ko'nikmaning nomi, darajasi va ikonkasini saqlaydigan model
    public class SkillModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(0, 100)]
        public int Level { get; set; }

        public string? Icon { get; set; }

        public string? Description { get; set; }

        public string? Color { get; set; }

        public string Category { get; set; } = "General";
    }
}
