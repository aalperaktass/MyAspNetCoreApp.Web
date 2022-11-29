using Microsoft.EntityFrameworkCore;

namespace MyAspNetCoreApp.Web.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) // options sınıfı hangi veri tabanını kullanacağımızı belirtir ve içerisine neyi optionluyorsak onu yazarız ve onun seçeneklerini belirtiriz.
                                                                                  // seçeneklerin gideceği yer basedeki yani miras aldığımız constructora.
                                                                                  //Optionsları proğram.cs dosyasında dolduracağız.
        {

        }
        public DbSet<Product> Products { get; set; }  //Bu sınıfta maplediğimiz databasenin ismi ne ise onu vermek best practic olarak önemli 
    }
}
