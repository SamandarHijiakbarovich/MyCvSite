using System.ComponentModel.DataAnnotations;

namespace MyCvSite.Data
{
    public class ProjectModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public string[] Technologies { get; set; } = Array.Empty<string>();

        public string GithubUrl { get; set; } = string.Empty;

        public string LiveDemoUrl { get; set; } = string.Empty;
    }
}