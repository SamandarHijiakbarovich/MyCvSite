using MyCvSite.Data;

namespace MyCvSite.Services
{
    /// <summary>
    /// Saytdagi barcha loyiha ma'lumotlari uchun yagona manba (single source of truth).
    /// Ma'lumotlar GitHub profilidagi omborlar asosida kiritilgan.
    /// </summary>
    public class ProjectService
    {
        public const string GithubProfile = "https://github.com/SamandarHijiakbarovich";

        public List<ProjectModel> GetProjects()
        {
            return new List<ProjectModel>
            {
                new ProjectModel
                {
                    Id = 1,
                    Title = "Darmon",
                    Tagline = "Dorixona platformasi",
                    Category = "Web",
                    IsFeatured = true,
                    Status = "Tayyor",
                    Description = "Dorixonalardagi dori vositalarini topish, narxlarni solishtirish va onlayn buyurtma berish imkonini beruvchi yetkazib berish platformasi. Katalog, savat, buyurtma boshqaruvi va to'lov integratsiyasi.",
                    ImageUrl = "images/projects/darmon.webp",
                    Technologies = new[] { "ASP.NET Core", "EF Core", "PostgreSQL", "JWT", "Click API", "Clean Architecture" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/Darmon"
                },
                new ProjectModel
                {
                    Id = 2,
                    Title = "Jetar.uz",
                    Tagline = "Escrow savdo platformasi",
                    Category = "Web",
                    IsFeatured = true,
                    Status = "MVP",
                    Description = "O'yin akkauntlarini Escrow kafolati bilan xavfsiz savdo qilish platformasi. E'lon joylash, escrow bitimi, to'lov, chat, reyting va nizolarni moderatsiya qilish to'liq ishlaydi.",
                    ImageUrl = "images/projects/jetar.webp",
                    Technologies = new[] { ".NET 9", "React 19", "TypeScript", "PostgreSQL", "Redis", "Tailwind", "PWA" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/Jetar.uz"
                },
                new ProjectModel
                {
                    Id = 3,
                    Title = "EduProctor",
                    Tagline = "AI imtihon nazorati",
                    Category = "AI",
                    IsFeatured = true,
                    Status = "Tayyor",
                    Description = "AI asosidagi onlayn imtihon nazorat tizimi. Real vaqtda yuz tanish, xatti-harakat tahlili va SignalR orqali jonli monitoring, shuningdek tashkilot, guruh va test boshqaruvi.",
                    ImageUrl = "images/projects/eduproctor.webp",
                    Technologies = new[] { "ASP.NET Core", "SignalR", "EF Core", "PostgreSQL", "AI/ML", "Docker" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/EduProctor"
                },
                new ProjectModel
                {
                    Id = 4,
                    Title = "DataClustAI",
                    Tagline = "Excel AI kategorizator",
                    Category = "AI",
                    IsFeatured = true,
                    Status = "Tayyor",
                    Description = "Excel (.xlsx) fayllardagi matnli ma'lumotlarni sun'iy intellekt yordamida avtomatik kategoriyalarga ajratuvchi veb-ilova. Gemini, Groq, OpenRouter va lokal Ollama qo'llab-quvvatlanadi.",
                    ImageUrl = "images/projects/dataclustai.webp",
                    Technologies = new[] { "ASP.NET Core MVC", "Gemini API", "Groq", "Ollama", "EF Core", "Docker" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/DataClustAI"
                },
                new ProjectModel
                {
                    Id = 5,
                    Title = "SafeLink",
                    Tagline = "Favqulodda yordam ilovasi",
                    Category = "Mobil",
                    IsFeatured = true,
                    Status = "MVP",
                    Description = "Favqulodda holatlarda bitta tugma bilan yordam chaqiruvchi mobil ilova. GPS joylashuv, audio yozuv, 102 ga avtomatik murojaat va ishonchli kontaktlarni xabardor qilish — 3 soniya ichida.",
                    ImageUrl = "images/projects/safelink.webp",
                    Technologies = new[] { ".NET MAUI", "C#", "GPS Geolocation", "REST API", "Android" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/SafeLink"
                },
                new ProjectModel
                {
                    Id = 6,
                    Title = "EduKitob",
                    Tagline = "Kitob marketplace",
                    Category = "Web",
                    IsFeatured = true,
                    Status = "Tayyor",
                    Description = "O'zbekistondagi yetakchi ilmiy nashriyotlarni bitta platformaga jamlovchi kitob marketplace. Katalog, savat, kuryer boshqaruvi, audit jurnali va admin panel bilan to'liq backend.",
                    ImageUrl = "images/projects/edukitob.webp",
                    Technologies = new[] { "ASP.NET Core", "Clean Architecture", "PostgreSQL", "Docker", "CI/CD", "Swagger" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/EduKitob"
                },
                new ProjectModel
                {
                    Id = 7,
                    Title = "GamxorOila Backend",
                    Tagline = "Family Care API",
                    Category = "Backend",
                    IsFeatured = false,
                    Status = "Tayyor",
                    Description = "Oila parvarishi uchun Flutter ilovasiga xizmat qiluvchi backend. Clean Architecture asosida qayta yozilgan, mavjud API kontrakti to'liq saqlangan, OTP autentifikatsiya va PostgreSQL.",
                    ImageUrl = "images/projects/gamxor.webp",
                    Technologies = new[] { ".NET 9", "Clean Architecture", "EF Core", "PostgreSQL", "OTP", "Flutter API" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/GamxorBackend"
                },
                new ProjectModel
                {
                    Id = 8,
                    Title = "MaqsadAI",
                    Tagline = "Mikroservis arxitekturasi",
                    Category = "Backend",
                    IsFeatured = false,
                    Status = "Ishlab chiqilmoqda",
                    Description = "AI asosidagi maqsad va karyera platformasining backend qismi. YARP API Gateway orqali boshqariladigan mikroservislar, event-driven arxitektura va umumiy kernel paketlari.",
                    ImageUrl = "images/projects/maqsadai.webp",
                    Technologies = new[] { ".NET 10", "Mikroservis", "YARP Gateway", "Event-Driven", "Clean Architecture" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/MaqsadAi.uz"
                },
                new ProjectModel
                {
                    Id = 9,
                    Title = "MarketPlace",
                    Tagline = "Elektronika do'koni MVP",
                    Category = "Web",
                    IsFeatured = false,
                    Status = "MVP",
                    Description = "Elektronika do'koni uchun marketplace MVP: katalog, savat, to'lov (mock), yetkazib berish va admin panel. Clean Architecture qatlamlari va JWT asosida qurilgan.",
                    ImageUrl = "images/projects/marketplace.webp",
                    Technologies = new[] { "ASP.NET Core 9", "Clean Architecture", "React", "TypeScript", "PostgreSQL", "JWT" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/MarketPlace"
                },
                new ProjectModel
                {
                    Id = 10,
                    Title = "Modal So'zlar Lug'ati",
                    Tagline = "Offline mobil lug'at",
                    Category = "Mobil",
                    IsFeatured = false,
                    Status = "Tayyor",
                    Description = "O'zbek tili modal so'zlari uchun to'liq offline ishlaydigan mobil ilova. 100+ so'z, tezkor qidiruv, A–Z ko'rinish, saqlanganlar, mashq testi, talaffuz va Light/Dark rejim.",
                    ImageUrl = "images/projects/modalsoz.webp",
                    Technologies = new[] { ".NET MAUI", "C#", "SQLite", "Text-to-Speech", "Offline" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/ModalSo-zlarLug-ati"
                },
                new ProjectModel
                {
                    Id = 11,
                    Title = "Qalb Muhri Bot",
                    Tagline = "Volontyorlik Telegram boti",
                    Category = "Bot",
                    IsFeatured = false,
                    Status = "Tayyor",
                    Description = "Qalb Muhri EVH uchun volontyorlik va ro'yxatdan o'tish Telegram boti. aiogram 3.x va SQLAlchemy (async) asosida yozilgan, Docker orqali joylashtiriladi.",
                    ImageUrl = "images/projects/qalbmuhri.webp",
                    Technologies = new[] { "Python", "aiogram 3.x", "SQLAlchemy", "PostgreSQL", "Docker" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/qalbmuhri-bot"
                },
                new ProjectModel
                {
                    Id = 12,
                    Title = "FootballManager API",
                    Tagline = "REST xizmat",
                    Category = "Backend",
                    IsFeatured = false,
                    Status = "Tayyor",
                    Description = "Futbol jamoalari, o'yinchilar, o'yinlar va gollar bilan ishlovchi RESTful API. JWT autentifikatsiya, rol asosidagi avtorizatsiya, AutoMapper va Swagger hujjatlari.",
                    ImageUrl = "images/projects/footballapi.webp",
                    Technologies = new[] { "ASP.NET Core", "EF Core", "AutoMapper", "SQL Server", "JWT", "Swagger" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/FootballManagerApi"
                },
                new ProjectModel
                {
                    Id = 13,
                    Title = "Media Bot",
                    Tagline = "Rasm, video va musiqa boti",
                    Category = "Bot",
                    IsFeatured = false,
                    Status = "Tayyor",
                    Description = "Pexels, Spotify va Jamendo manbalaridan rasm, video va musiqa qidiruvchi Telegram bot. Modulli monolit arxitektura, ko'p tilli menyu, Docker va CI/CD tayyorligi.",
                    ImageUrl = "images/projects/mediabot.webp",
                    Technologies = new[] { ".NET 8", "Telegram.Bot", "Pexels API", "Spotify API", "Docker", "CI/CD" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/-Video-And-bot"
                },
                new ProjectModel
                {
                    Id = 14,
                    Title = "Biznes Ro'yxati Testi",
                    Tagline = "Onlayn test tizimi",
                    Category = "Frontend",
                    IsFeatured = false,
                    Status = "Tayyor",
                    Description = "O'zbekistonda biznesni ro'yxatga olish bo'yicha onlayn test ilovasi. Uch xil test to'plami, jami 350+ savol, ABCD variantlari, bo'limlar bo'yicha natija va mustaqil ishlaydigan sahifa.",
                    ImageUrl = "images/projects/biznesroyxati.webp",
                    Technologies = new[] { "HTML5", "JavaScript", "CSS3", "Responsive" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/biznes-royxati-test"
                },
                new ProjectModel
                {
                    Id = 15,
                    Title = "AlgoSim Simulator",
                    Tagline = "Algoritm vizualizatori",
                    Category = "Frontend",
                    IsFeatured = false,
                    Status = "MVP",
                    Description = "Algoritmlarni vizual simulyatsiya qiluvchi interaktiv veb-ilova. JavaScript va HTML Canvas asosida ishlash jarayonini qadam-baqadam kuzatish imkoniyati.",
                    ImageUrl = "images/projects/algosim.webp",
                    Technologies = new[] { "JavaScript", "HTML Canvas", "CSS3", "Algoritmlar" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/algosim-simulator"
                },
                new ProjectModel
                {
                    Id = 16,
                    Title = "Pentest Portfolio",
                    Tagline = "Xavfsizlik auditi",
                    Category = "Xavfsizlik",
                    IsFeatured = false,
                    Status = "Tayyor",
                    Description = "Web ilovalar xavfsizligi bo'yicha penetratsion test metodologiyasi va hisobotlar portfeli. OWASP Top 10, recon/OSINT yondashuvi va buzg'unchi bo'lmagan (non-destructive) test usuli.",
                    ImageUrl = "images/projects/pentest.webp",
                    Technologies = new[] { "PowerShell", "OWASP Top 10", "OSINT", "Reporting", "Burp Suite" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/pentest-methodology-portfolio"
                },
                new ProjectModel
                {
                    Id = 17,
                    Title = "Total Commander Console",
                    Tagline = "Konsol fayl menejeri",
                    Category = "Konsol",
                    IsFeatured = false,
                    Status = "Tayyor",
                    Description = "Total Commander uslubidagi konsol fayl menejeri. Papka va fayllar bo'ylab navigatsiya, nusxalash, ko'chirish, o'chirish va joriy katalog tarkibini ko'rish amallari C# da.",
                    ImageUrl = "images/projects/totalcmd.webp",
                    Technologies = new[] { "C#", ".NET", "OOP", "File System API" },
                    GithubUrl = "https://github.com/SamandarHijiakbarovich/TotalCommanderConsoleApp"
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
