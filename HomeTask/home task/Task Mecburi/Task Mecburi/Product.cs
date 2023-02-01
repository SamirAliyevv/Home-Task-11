using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Mecburi
{
    internal class Product
    {
        public  int No;
        public string Category;
        public double Price;
        private static int _totalcount;
        public Product()
        {
            _totalcount++;
            No= _totalcount;


        }


    }
}
