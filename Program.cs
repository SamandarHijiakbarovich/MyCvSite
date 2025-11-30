using MyCvSite; // App.razor uchun
using MyCvSite.Components; // Layout va UI komponentlar uchun
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// ?? Servislar ro‘yxati
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(); // Blazor Server interaktiv render

// ?? Ilovani qurish
var app = builder.Build();

// ?? HTTP pipeline konfiguratsiyasi
if (!app.Environment.IsDevelopment())
{
    // Xatolik sahifasi va xavfsizlik
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts(); // HTTPS xavfsizligi (production uchun)
}
else
{
    // Ishlab chiqish rejimi uchun developer tools
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection(); // HTTP ? HTTPS yo‘naltirish
app.UseStaticFiles();       // wwwroot ichidagi fayllarni xizmat qilish
app.UseRouting();           // URL marshrutlash
app.UseAntiforgery();       // CSRF himoyasi

// ?? App.razor yuklanadi va interaktiv render qo‘llaniladi
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run(); // Ilovani ishga tushirish
