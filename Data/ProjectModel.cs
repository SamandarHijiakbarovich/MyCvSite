namespace MyCvSite.Data
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; } // Masalan: "images/project-1-ss.png"
        public string[] Technologies { get; set; } // Ishlatilgan texnologiyalar ro'yxati
        public string GithubUrl { get; set; }
        public string LiveDemoUrl { get; set; }
    }
}