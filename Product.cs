using System;
using System.Collections.Generic;
using System.Text;

namespace Black_Friday
{
    class Product
    {
        int price;
        string name;

        public static Product createInstance(string name, int price)
        {
            Product temp =  new Product();
            temp.setName(name);
            temp.setPrice(price);

            return temp;
        }


        private Product() { }

        public int getPrice()
        {
            return price;
        }

        public string getName() { return name; }

        private void setName(String productName) { name = productName; }

        private void setPrice(int productPrice) { price = productPrice; }
    }
}
