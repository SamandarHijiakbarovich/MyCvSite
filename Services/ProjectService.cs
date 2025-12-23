using MyCvSite.Data;

namespace MyCvSite.Services
{
    public class ProjectService
    {
        public List<ProjectModel> GetProjects()
        {
            return new List<ProjectModel>
            {
               new ProjectModel
{
    Id = 3,
    Title = "Online Do'kon API",
    Description = "E-tijorat tizimi uchun ishlab chiqilgan, JWT authentication va Role-based authorization tizimiga ega REST API.",
    Technologies = new[] { "ASP.NET Core Web API", "SQL Server", "JWT", "Swagger" },
    GithubUrl = "https://github.com/sizning-profil/shop-api",
    ImageUrl = "images/api-project.jpg"
},
new ProjectModel
{
    Id = 4,
    Title = "Telegram Bot (Xizmat ko'rsatish)",
    Description = "Mijozlar uchun navbatga turish yoki mahsulot buyurtma qilish imkonini beruvchi interaktiv bot.",
    Technologies = new[] { "Telegram.Bot Library", "C#", "PostgreSQL" },
    GithubUrl = "https://github.com/sizning-profil/service-bot",
    ImageUrl = "images/bot-project.jpg"
},
new ProjectModel
{
    Id = 5,
    Title = "Vazifalar Boshqaruv Tizimi (Task Manager)",
    Description = "Jamoa uchun vazifalarni belgilash, muddatlarni kuzatish va hisobotlar tayyorlash paneli.",
    Technologies = new[] { "Blazor WebAssembly", "Entity Framework Core", "Clean Architecture" },
    GithubUrl = "https://github.com/sizning-profil/task-manager",
    ImageUrl = "images/task-project.jpg"
},
new ProjectModel
{
    Id = 6,
    Title = "Valyuta Kurslari Monitori",
    Description = "Markaziy bank API-lari bilan ishlovchi, real vaqt rejimida kurslarni kuzatuvchi va grafiklarda ko'rsatuvchi dastur.",
    Technologies = new[] { "C#", "HttpClient", "MudBlazor (UI Library)" },
    GithubUrl = "https://github.com/sizning-profil/currency-tracker",
    ImageUrl = "images/currency-project.jpg"
}
            };
        }

        public List<SkillModel> GetSkills()
        {
            return new List<SkillModel>
            {
                new SkillModel { Id = 1, Name = "C#", Level = 90, Color = "#512bd4", Category = "Backend" },
                new SkillModel { Id = 2, Name = "Blazor", Level = 85, Color = "#512bd4", Category = "Frontend" },
                new SkillModel { Id = 3, Name = "SQL", Level = 75, Color = "#00758f", Category = "Database" },
                new SkillModel
                    {
                        Id = 4,
                        Name = "Web Security (OWASP)",
                        Level = 80,
                        Color = "#e34c26",
                        Category = "Cybersecurity",
                        Description = "SQL Injection, XSS va CSRF hujumlaridan himoyalanish tajribasi.",
                        Icon = "bi bi-shield-lock"
                    },
                    new SkillModel
                    {
                        Id = 5,
                        Name = "Penetration Testing",
                        Level = 65,
                        Color = "#4d4d4d",
                        Category = "Cybersecurity",
                        Description = "Tizim zaifliklarini aniqlash va xavfsizlik auditini o'tkazish.",
                        Icon = "bi bi-bug"
                    },
                    new SkillModel
                    {
                        Id = 6,
                        Name = "Network Security",
                        Level = 70,
                        Color = "#0056b3",
                        Category = "Cybersecurity",
                        Description = "Firewall, VPN va tarmoq trafigini monitoring qilish.",
                        Icon = "bi bi-common-connectivity"
                    },
                    new SkillModel
                    {
                        Id = 7,
                        Name = "Cryptography",
                        Level = 75,
                        Color = "#ffc107",
                        Category = "Cybersecurity",
                        Description = "Ma'lumotlarni shifrlash algoritmlari (AES, RSA) va Hashing bilan ishlash.",
                        Icon = "bi bi-key"
                    },
                    new SkillModel
                    {
                        Id = 8,
                        Name = "Identity Management",
                        Level = 85,
                        Color = "#28a745",
                        Category = "Cybersecurity",
                        Description = "OAuth2, OpenID Connect va Multi-factor authentication (MFA) tatbiq etish.",
                        Icon = "bi bi-person-check"
                    }
            };
        }
    
    }
}
