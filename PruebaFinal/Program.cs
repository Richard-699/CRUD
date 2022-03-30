using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using PruebaFinal.DTOS;
using PruebaFinal.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var mapperConfig = new MapperConfiguration(m =>
  {
      m.AddProfile(new MapperConfig());
  });
IMapper mapper=mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddMvc();

builder.Services.AddDbContext<ClienteDbContext>(
options =>
options.UseSqlServer("data source=localhost;initial catalog=Registro;user id=sa;password=HWI2022*;"));

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
