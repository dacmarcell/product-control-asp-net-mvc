using Microsoft.EntityFrameworkCore;
using ProductControl.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DatabaseContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("DataBase")
        )
    );

builder.Services.AddRazorPages().AddMvcOptions(options =>
{
    options.MaxModelValidationErrors = 50;
    options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(_ => "This field is required!");
});

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
