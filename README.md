# MyCvSite — Samandar Mamasoatov portfoli sayti

Shaxsiy portfolio va rezyume sayti. **Blazor Server (.NET 9)** asosida yozilgan,
Render.com'da joylashtirilgan va **mamasoatovsamandar.uz** domenida ishlaydi.

## Sahifalar

| Yo'l | Tavsif |
| --- | --- |
| `/` | Bosh sahifa — tanishtiruv, statistika, ijtimoiy tarmoqlar, CyberLab kanali bloki |
| `/about` | Men haqimda — tajriba, ta'lim, yutuqlar |
| `/projects` | Loyihalar — qidiruv va yo'nalish bo'yicha filtr bilan 17 ta loyiha |
| `/skills` | Ko'nikmalar — backend, ma'lumotlar bazasi va kiberxavfsizlik |
| `/services` | Xizmatlar |
| `/contact` | Aloqa formasi |

## Arxitektura

```
Components/
  Layout/      MainLayout (sidebar + topbar), NavMenu
  Pages/       Home, About, Projects, Skills, Services, Contact, Error
  UI/          ProjectCard, SocialIcon
Data/          ProjectModel, SkillModel, ContactModel
Services/      ProjectService  ← barcha loyiha ma'lumotlari uchun yagona manba
wwwroot/
  css/         app.css, portfolio.css
  images/      my-photo.*, projects/*.webp (loyiha muqovalari)
  js/          app.js, aboutPage.js, skillbar.js
  Files/       SamandarResume.pdf
```

### Loyihalarni qanday qo'shish

Yangi loyiha qo'shish uchun faqat bitta joy o'zgartiriladi —
`Services/ProjectService.cs` ichidagi `GetProjects()` ro'yxati:

```csharp
new ProjectModel
{
    Id = 18,
    Title = "Yangi loyiha",
    Tagline = "Qisqa shior",
    Category = "Web",              // Web | Backend | AI | Mobil | Bot | Xavfsizlik | Frontend | Konsol
    IsFeatured = false,            // true bo'lsa ro'yxat boshida chiqadi
    Status = "Tayyor",             // Tayyor | MVP | Ishlab chiqilmoqda
    Description = "Loyiha haqida 1-2 gaplik izoh.",
    ImageUrl = "images/projects/yangi-loyiha.webp",
    Technologies = new[] { "ASP.NET Core", "PostgreSQL" },
    GithubUrl = "https://github.com/SamandarHijiakbarovich/yangi-loyiha",
    LiveDemoUrl = ""               // bo'sh bo'lsa havola ko'rsatilmaydi
}
```

Yo'nalishlar (Category) va filtr tugmalari ro'yxatdan avtomatik hosil qilinadi —
yangi turkum qo'shsangiz, filtr paneli ham o'zi yangilanadi.

Muqova rasmi `wwwroot/images/projects/` ichiga qo'yiladi. Tavsiya etilgan
nisbat — **900 × 520** (taxminan 1.73:1), `.webp` formati.

## Ishga tushirish

```bash
dotnet restore
dotnet run
```

Standart manzil: `https://localhost:7xxx` yoki `http://localhost:5xxx`
(`Properties/launchSettings.json` ga qarang).

## Docker

```bash
docker build -t mycvsite .
docker run -p 8080:8080 mycvsite
```

## Joylashtirish

`main` shoxobchasiga push qilinganda Render.com avtomatik ravishda Docker orqali
qayta quradi. Sayt Cloudflare orqali **mamasoatovsamandar.uz** domenida xizmat qiladi.

## Muallif

**Samandar Mamasoatov** — .NET Backend dasturchi
[GitHub](https://github.com/SamandarHijiakbarovich) · [Telegram](https://t.me/LinuxInstructor)

## CyberLab

**CyberLab** — IT kompaniyamizning rasmiy Telegram kanali: cybersecurity,
dasturlash va ethical hacking bo'yicha amaliy qo'llanmalar va kodlar.

👉 [t.me/CyberLabCode](https://t.me/CyberLabCode)
