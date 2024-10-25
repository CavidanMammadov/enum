using Core.Helper.Enum;
using Core.Models;
using System.Net.Http.Headers;

namespace storetask.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                Name = "corek",
                Price = 0.55,
                Type = Types.Baker
            };
            Product product1 = new Product()
            {
                Name = "cola",
                Price = 2.2,
                Type= Types.Drink
            };
            Product product2 = new Product()
            {
                Name = "et",
                Price = 15,
                Type = Types.Meat
            };
            Product product3 = new Product()
            {
                Name= "yemek",
                Price =15,  
                Type= Types.Diary
            }
            Store store = new Store("Araz");
            store.AddProduct(product,product1,product2 );

            store.GetElementByName("corek");


        }
    }
}
