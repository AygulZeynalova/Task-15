using Task15.Models.Entities;

namespace Task15.Models.Contexts
{
    internal static class DataSeed
    {
        internal static IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using(var scope= app.ApplicationServices.CreateScope())
            {
                var db=scope.ServiceProvider.GetRequiredService<DataContext>();

                var list = new[]
                {
                    new Country {Id=1, Name="Azerbaijan", Code="+994" },
                    new Country {Id=2, Name="USA", Code="+1"}
                };

                db.Countries.AddRange(list);
                db.SaveChanges();
            }
            return app;
        }
    }
}
