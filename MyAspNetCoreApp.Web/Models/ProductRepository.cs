using MyAspNetCoreApp.Web.Models;
using System.Linq.Expressions;

namespace MyAspNetCoreApp.Web.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>()  // Burada bir liste ve data oluşturduk. Aşağıdaki yazacağımız metodlarla bu listeyi dış dünyaya açacağız.
        {
            new() { Id = 1, Name = "Kalem", Price = 100, Stock = 20 },
            new () { Id = 2, Name = "Silgi", Price = 80, Stock = 11 },
            new () { Id = 3, Name = "Kalemlik", Price = 30, Stock = 16 },
            new() { Id = 4, Name = "Açacak", Price = 20, Stock = 14 }

        };
            

        public List<Product> GetAll() => _products;

        public void Add(Product newProduct) => _products.Add(newProduct);

        public void Remove(int Id)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == Id); // Bu metod ile böyle bir datanın olup olmadığını kontrol ediyoruz. X = _products 
            if (hasProduct == null)
            {
                throw new Exception($"Bu id({Id})'ye sahip ürün bulunmamaktadır");
            }
            _products.Remove(hasProduct);
        }
        public void Update(Product updateProduct)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == updateProduct.Id);
            if (hasProduct == null)
            {
                throw new Exception($"Bu id({updateProduct.Id})'ye sahip ürün bulunmamaktadır");
            }


            hasProduct.Name = updateProduct.Name;
            hasProduct.Stock = updateProduct.Stock;
            hasProduct.Price = updateProduct.Price;

            //Güncellenen dataları geri gönderilebilmek için bizim dizin içindeki product'ın  id'sinin indexini  bulmamız gerekiyor.
            var index = _products.FindIndex(x => x.Id == updateProduct.Id);

            // Bir değişken tanımlayıp _products'ın indexini bulduk. Sonrasında bu  indexteki datayı  hasProduct'a  olarak güncelledik.
            _products[index] = hasProduct;
        }
    }
}
