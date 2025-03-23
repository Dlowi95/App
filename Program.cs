using App.ExtendMethods;
using App.Services;
using Microsoft.AspNetCore.Routing.Constraints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ProductService>();
builder.Services.AddSingleton<PlanetService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.AddStatusCodePage(); // Tuy bien loi Response 400 - 599

app.UseRouting();

app.UseAuthentication(); // xac dinh danh tinh
app.UseAuthorization(); // xac dinh quyen truy cap

app.MapGet("/sayhi",async (context) => {
    await context.Response.WriteAsync($"Hello ASP.NET MVC {DateTime.Now}");
});
// app.MapRazorPages();

app.MapControllerRoute(
    name: "first",
    pattern: "{url:regex(^((xemsanpham)|(viewproduct))$)}/{id:range(2,4)}",
    defaults: new { controller = "First",
    action = "ViewProduct" }
);
app.MapAreaControllerRoute(
    name: "product",
    pattern: "/{controller}/{action=Index}/{id?}",
    areaName: "ProductManage"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
