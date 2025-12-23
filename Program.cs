using Microsoft.AspNetCore.Components.Web;
using MyCvSite.Components; // Loyihangiz nomiga qarab tekshiring
using System.Globalization;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);

// 1. BLAZOR SERVISLARINI QO'SHISH
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// 2. LOKALIZATSIYA (Agar kerak bo'lsa)
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

// 3. HTTP CLIENT (Ma'lumotlar olish uchun)
builder.Services.AddHttpClient();

var app = builder.Build();

// ==================== MIDDLEWARE PIPELINE ====================

// 4. XATOLIKLARNI BOSHQARISH
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

// 5. STATIK FAYLLAR (CSS, JS, Rasmlar)
app.UseStaticFiles();

// 6. LOKALIZATSIYA SOZLAMALARI
var supportedCultures = new[] { "uz", "en", "ru" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("uz")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

// 7. ROUTING VA XAVFSIZLIK (Eng asosiylari)
app.UseRouting();
app.UseAntiforgery();

// 8. BLAZOR KOMPONENTLARINI MAP QILISH
app.MapRazorComponents<App>() // Bu yerda App.razor nazarda tutilgan
    .AddInteractiveServerRenderMode();

app.Run();