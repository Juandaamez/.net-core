
using test01.Models;

namespace test01.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //Office

                if (!context.Office.Any())
                {
                    context.Office.AddRange(new List<Office>()
                    {
                    new Office()

                    {
                        City="Tunja",
                        Phone="3123456432",
                        Address1="Cra 10 #10-10",
                        Address2="Cra 10 #10-10",
                        State="Boyaca",
                        Country="Colombia",
                        PostalCode="15002",
                        Territory="Colombian"

                    }


                    });

                    context.SaveChanges();
                }

                //Office

                if (!context.ProductLine.Any())
                {
                    context.ProductLine.AddRange(new List<ProductLine>()
                    {
                    new ProductLine()

                    {
                        DescInText="Test",
                        DescInHtml="Test",
                        Image="Test"

                    }


                    });

                    context.SaveChanges();
                }
            }
        }
    } 
}
