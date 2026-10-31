using ecommerce_mvc_tutorial.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*
- bu satır oluşturduğumuz EF context'ini uygulamaya tanıtır.
- appsettings dosyasından connection string bölümü otomatik olarak alınır.
- dbContext'in sqLite kullanması ayarı yapılır. SQLite da kurulan EF paketinin SQLite olması sebebiyle elimizde bulunmaktadır.
*/
builder.Services.AddDbContext<DataContext>(options =>
{
    var connString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlite(connString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "products_by_category",
    pattern: "products/{url?}",
    defaults: new { controller = "Product", action = "List" })
    .WithStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
