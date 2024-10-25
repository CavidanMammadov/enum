using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Store

    {

        public Product this[int No] { get { return Products[No]; } set { Products[No] = value; } }
        public int Lenght { get { return Products.Length; } }
        public string Name { get; set; }
        Product[] Products;
        public Store(string name)
        {
            Name = name;
            Products = new Product[0];
        }
        public void AddProduct(params Product[] newProducts)
        {
            int OldCount = Products.Length;
            Array.Resize(ref Products, Products.Length + newProducts.Length);
            for (int i = 0; i < newProducts.Length; i++) { Products[OldCount + i] = newProducts[i]; }

        }
        public Product[] FilterProductsByType(string type)
        {
            Product[] foundedProducts = new Product[0];
            foreach (var item in Products)
            {
                if (item.Type == type)
                {
                    Array.Resize(ref foundedProducts, foundedProducts.Length + 1);
                    foundedProducts[foundedProducts.Length - 1] = item;
                    return foundedProducts;
                }
            }
            return foundedProducts;



        }
        public Product[] FilterProductByName(string name)
        {
            Product[] foundedProduct = new Product[0];
            foreach (var item in foundedProduct)
            {
                if (item.Name == name)
                {
                    Array.Resize(ref foundedProduct, foundedProduct.Length + 1);
                    foundedProduct[foundedProduct.Length - 1] = item;
                    return foundedProduct;
                }

            }
            return foundedProduct;
        }
        public void GetElementByName(string name)
        {
            foreach (var item in Products)
            {
                if (item.Name == name)
                {
                    Console.WriteLine($" name{name}");
                }
            }
        }

    }
}