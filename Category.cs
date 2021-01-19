using System;
using System.Collections.Generic;
using System.Text;

namespace Black_Friday
{
    class Category
    {
        string name;
        Array productNames;
        Array productPrices;

        private Category() { }

        public static Category createInstance(string name, string[] productsNameList, double[] productsPriceList, int size)
        {
            Category temp = new Category();
            temp.setName(name);
            temp.setProductNames(productsNameList, size);
            temp.setProductPrices(productsPriceList, size);

            return temp;
        }

        private void setName(string categoryName)
        {
            name = categoryName;
        }

        private void setProductNames(string[] productNamesList, int size)
        {
            productNames = Array.CreateInstance(typeof(string), size);
            for(int i = 0; i < size; i++)
            {
                productNames.SetValue(productNamesList[i], i);
            }
        }

        private void setProductPrices(double[] productPriceList, int size)
        { 
            productPrices = Array.CreateInstance(typeof(double), size);
            for (int i = 0; i < size; i++)
            {
                productPrices.SetValue(productPriceList[i], i);
            }
        }

        public string getName() => name;

        public Array getProductNames()
        {
            return productNames;
        }
        public Array getProductPrices => productPrices;
    }
}
