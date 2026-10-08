using System.ComponentModel.DataAnnotations;

namespace MyCvSite.Data
{
    public class ProjectModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        /// <summary>Loyihaning qisqa shiori / muqovadagi izoh.</summary>
        public string Tagline { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public string[] Technologies { get; set; } = Array.Empty<string>();

        public string GithubUrl { get; set; } = string.Empty;

        public string LiveDemoUrl { get; set; } = string.Empty;

        /// <summary>Loyiha turkumi: Web, Backend, AI, Mobil, Bot, Xavfsizlik, Frontend, Konsol.</summary>
        public string Category { get; set; } = "Web";

        /// <summary>Asosiy (yorqin) loyihalar ro'yxat boshida ko'rsatiladi.</summary>
        public bool IsFeatured { get; set; }

        /// <summary>Loyiha holati: "Tayyor", "Ishlab chiqilmoqda", "MVP".</summary>
        public string Status { get; set; } = "Tayyor";
    }
}
