using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Task_Mecburi
{
    internal class Store
    {

        public Product[] products;


        public void AddProduct(Product products1 )
        {

            Array.Resize( ref products,products.Length+1 );
            products[products.Length - 1] = products1; 


        }
        public bool HasProductByno(int no)
        {
            for (int i = 0; i < products.Length; i++)
            {

                if (products[i].No==no)
                {
                    return true;
                }
            }
            return false;

        }
        public bool  GetProductBuNo(int no)
        {
        
            for (int i = 0; i < products.Length; i++)
            {

                if (products[i].No==no)
                {

                    return true;
                }
               
            }
            return false;
         



        }


    }
}
