using System;
using Newtonsoft.Json;

namespace SeDeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P R O D U C T  S E R I A L I Z A T I O N");
            string json=DoSerialization();
            DoDeserialization(json);
            Console.ReadLine();
        }

        static string DoSerialization(){
            Product[] products={
                new Product(){ID=101, Name="Product - 101", Price=1.00},
                new Product(){ID=102, Name="Product - 102", Price=2.00},
                new Product(){ID=103, Name="Product - 103", Price=3.00}
            };

            string json=JsonConvert.SerializeObject(products);
            Console.WriteLine(json);
            return json;
        }

        static void DoDeserialization(string json){
            Product[] products=JsonConvert.DeserializeObject<Product[]>(json);

            foreach(Product product in products) Console.WriteLine("ID = {0}, Name = {1}, Price = {2}", product.ID, product.Name, product.Price);
        }
    }

    
}
