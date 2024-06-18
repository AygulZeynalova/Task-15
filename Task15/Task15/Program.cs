namespace Task15
{
    using Microsoft.EntityFrameworkCore;
    using Task15.Models.Contexts;


    namespace WebIntroEmpty
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                var builder = WebApplication.CreateBuilder(args);

                builder.Services.AddControllersWithViews();

                builder.Services.AddDbContext<DataContext>(cfg =>
                {
                    cfg.UseInMemoryDatabase("CountriesDb");
                });

                var app = builder.Build();
                app.UseStaticFiles();
                //app.MapDefaultControllerRoute();
                app.MapControllerRoute(name: "default", pattern: "{controller=countries}/{action=index}/{id?}");

               app.Seed();

                app.Run();
            }
        }
    }
}
