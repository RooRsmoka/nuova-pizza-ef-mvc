using Microsoft.EntityFrameworkCore;
using nuova_pizza_ef_mvc;

var builder = WebApplication.CreateBuilder(args);

string sConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PizzaContext>(options => options.UseSqlServer(sConnectionString));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pizza}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{

}
    
    
app.Run();
