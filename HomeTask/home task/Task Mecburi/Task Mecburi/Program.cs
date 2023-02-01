using System;

namespace Task_Mecburi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[0];
            Store store = new Store();

            Product product1 = new Product()
            {

                Category = "Alkoqollu icki",
                Price = 100,


            };
            Product product2 = new Product()
            {

                Category = "Un melumatlari",
                Price = 0.70,


            };

            Product product3 = new Product()
            {
                Category = "Sirniyyat",
                Price = 2.30,


            };

            Console.WriteLine(product3.Price);


            //try
            //{
            //    store.AddProduct(product1);
            //    store.AddProduct(product2);
            //    store.AddProduct(product3);
              
            //}
            //catch (NotFoundProduct)
            //{

              
            //}


            //products[0] = product1;
            //products[1] = product2;
            //products[2] = product3; 





        }
    }
}
