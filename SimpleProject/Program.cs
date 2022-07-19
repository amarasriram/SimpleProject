using Microsoft.EntityFrameworkCore;
using SimpleProject.Models;
var builder = WebApplication.CreateBuilder(args);
string connString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ITeamARepository,TeamARepository>();
builder.Services.AddScoped<ITeamBRepository,TeamBRepository>();
builder.Services.AddScoped<ITeamCRepository,TeamCRepository>();
builder.Services.AddScoped<ITeamDRepository,TeamDRepository>();
builder.Services.AddScoped<IMaleFemaleRepository, MaleFemaleRepository>();
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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{studentId?}");

app.Run();
