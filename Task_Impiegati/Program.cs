using Microsoft.EntityFrameworkCore;
using Task_Impiegati.Models;
using Task_Impiegati.Repos;
using Task_Impiegati.Services;

namespace Task_Impiegati
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<TaskImpiegatiContext>(
            options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("Locale")
         )
     );
            builder.Services.AddScoped<ImpiegatiRepo>();
            builder.Services.AddScoped<ImpiegatiService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Impiegati/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Impiegati}/{action=Lista}/{id?}");

            app.Run();
        }
    }
}
