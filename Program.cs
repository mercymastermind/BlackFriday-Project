using System;

namespace Black_Friday
{
    class BlackFiday
    {
        DayOfWeek friday = DayOfWeek.Friday;
        DateTime currentdt = DateTime.Now; 
        DateTime firstFriday;
        DateTime secondFriday;
        DateTime thirdFriday;
        DateTime lastFriday;
        DateTime staticDateTime = new DateTime(2020, 12, 04);

        enum fridaysOfTheMonth
        {
            firstFriday, secondFriday, thirdFriday, lastFriday
        }

        int option;
        int i;
        double discount;

        public fridaysOfTheMonth CheckFriday(DateTime day)
        {
            /*switch(day)
            {
                case firstFriday:
                    return fridaysOfTheMonth.firstFriday;
                    
            }*/

            if(day == firstFriday)
            {
                return fridaysOfTheMonth.firstFriday;
            }
            else if (day == secondFriday)
            {
                return fridaysOfTheMonth.secondFriday;
            }
            else if (day== thirdFriday)
            {
                return fridaysOfTheMonth.thirdFriday;
            }
            else if (day == lastFriday)
            {
                return fridaysOfTheMonth.lastFriday;
            }
        }
        public void welcome()
        {
            Console.WriteLine("Welcome To the biggest sales in Africa, Black Friday!");
            Console.WriteLine("Below are the lists of the black fridays and the categories of products with discounts on those days");
            getFridays();
            optionList();
        }
        public void getFridays()
        {
            firstFriday = new DateTime(2020, 12, 01);

            while (firstFriday.DayOfWeek != friday)
            {
                firstFriday = firstFriday.AddDays(1);
            }

            secondFriday = firstFriday.AddDays(7);

            thirdFriday = secondFriday.AddDays(7);
           
            lastFriday = thirdFriday.AddDays(7);

        }
        public void optionList()
        {
            Console.WriteLine("On " + firstFriday.ToString("F")+ " " + " The Clothing & Accessories Category is on Discount");
            Console.WriteLine("On " + secondFriday.ToString("F") + " " + " The Electronic Category is on Discount");
            Console.WriteLine("On " + thirdFriday.ToString("F") + " " + " The Automobiles Category is on Discount");
            Console.WriteLine("On " + lastFriday.ToString("F") + " " + " The Food & Household Items Category is on Discount");
            Console.WriteLine("What Category would you like to Shop from?");
            Console.WriteLine("Enter 1 for Clothing and Accessories\n" +
                "Enter 2 for Electronics\n" +
                "Enter 3 for Automobiles\n" +
                "Enter 4 for Food & Household Items");
            option = Convert.ToInt16(Console.ReadLine());
            optionChoice();
        }
        public void optionChoice()
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("Welcome to the Clothing and Acessories Category, we have great deals for you!");
                    clothingAccesories();
                    break;

                case 2:
                    Console.WriteLine("Welcome to the Electronics Category, we have great deals for you!");
                    electronics();
                    break;

                case 3:
                    Console.WriteLine("Welcome to the Clothing and Acessories Category, we have great deals for you!");
                    automobiles();
                    break;
                case 4:
                    Console.WriteLine("Welcome to the Clothing and Acessories Category, we have great deals for you!");
                    foodHousehold();
                    break;
                default:
                    Console.WriteLine("Please choose a category between 1-4 ");
                    optionList();
                    break;
            }
        }
        public void getDiscount()
        {
            if(currentdt == )
        }
        public void categoryChoice(String[] productList, double[] productPriceList[])
        {

        }
        public void clothingAccesories()
        {
            
            discount = 0.05;
            string[] Clothing_AccessoryList = new string[10] { "Blue Denim Jacket", "Ferragamo Slip-In Loafers", "Louboutini Red Bottom Heels", "Two-sided Bucket Hats", "Nike Off The Wall", "Brown Fenty Purse", "Fashion Winter Boots", "Off White Winter Coat", "Beluga Necklace", "Men Thick Cuban Chain" };
            double[] Clothing_AccessoryOriginalPriceList = new double[10] { 100, 2000, 4000, 50, 150, 500, 350, 1050, 900, 300 };
            if(staticDateTime == firstFriday)
            {
                Console.WriteLine("All Products in this category are at a discounted price of 5%(Black Friday Deals!!!)\n");
                /*foreach(var price in Clothing_AccessoryOriginalPriceList)
                {
                    double calculatedDiscount = (price - price * discount);
                    foreach(var product in Clothing_AccessoryList)
                    {
                        Console.WriteLine(product + "\nOriginal Price -> " + price + "$ \nDiscounted Price ->" + calculatedDiscount + "$ \n");

                    }
                }*/
                while (i < Clothing_AccessoryList.Length)
                {
                    double calculatedDiscount = (Clothing_AccessoryOriginalPriceList[i] - Clothing_AccessoryOriginalPriceList[i] * discount);
                    Console.WriteLine(Clothing_AccessoryList[i] + "\nOriginal Price -> " + Clothing_AccessoryOriginalPriceList[i] + "$ \nDiscounted Price ->" + calculatedDiscount + "$ \n");
                    i++;
                }
                
            }
            else
            {
                if (staticDateTime > firstFriday)
                {
                    Console.WriteLine("Sorry, but you have missed the discount on products in this category");
                    Console.WriteLine("All Products in this category are at their original prices\n");
                    while (i < Clothing_AccessoryList.Length)
                    {
                        Console.WriteLine(Clothing_AccessoryList[i] + "\nPrice -> " + Clothing_AccessoryOriginalPriceList[i] + "$ \n");
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("Discount for this Category will be on " + firstFriday.ToString("F"));
                    Console.WriteLine("All Products in this category are at their original prices");
                    while (i < Clothing_AccessoryList.Length)
                    {
                       
                        Console.WriteLine(Clothing_AccessoryList[i] + "\nPrice -> " + Clothing_AccessoryOriginalPriceList[i] + "$ \n");
                        i++;
                    }
                }
            }
        }
        public void electronics()
        {
            Console.WriteLine("Welcome to the Electronics Category, we have great deals for you!");
            discount = 0.1;
            string[] electronicsList = new string[10] { "Samsun A20", "LG 120 inch Solar TV", "Higher Thermocool Electronic Washing Machine", "HP Polaroid 15 inch Gaming Laptop", "Iphone 12 Pro", "Soundless Maxi Generator", "Iphone Earpods", "Tecno Camon 12", "HD Stereo Palma Set", "Touch Sensitive Light Box" };
            double[] electronicsOriginalPriceList = new double[10] { 1000, 2500, 400, 5050, 200, 500, 350, 450, 70, 120 };
            Console.WriteLine("Welcome to the Electronics Category, we have great deals for you!");
            if (currentdt == secondFriday)
            {
                Console.WriteLine("All Products in this category are at a discounted price of 10%(Black Friday Deals!!!)");
                while (i < electronicsList.Length)
                {
                    double calculatedDiscount = (electronicsOriginalPriceList[i] - electronicsOriginalPriceList[i] * discount);
                    Console.WriteLine(electronicsList[i] + "\nPrice -> " + electronicsOriginalPriceList[i] + "$ \nDiscounted Price ->" + calculatedDiscount+"$ \n");
                    i++;
                }
            }
            else
            {
                if (currentdt > secondFriday)
                {
                    Console.WriteLine("Sorry, but you have missed the discount on products in this category");
                    Console.WriteLine("All Products in this category are at their original prices");
                    while (i < electronicsList.Length)
                    {
                        Console.WriteLine(electronicsList[i] + "\nPrice -> " + electronicsOriginalPriceList[i] + "$ \n");
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("Discount for this Category will be on " + secondFriday.ToString("F"));
                    Console.WriteLine("All Products in this category are at their original prices");
                    while (i < electronicsList.Length)
                    {

                        Console.WriteLine(electronicsList[i] + "\nPrice -> " + electronicsOriginalPriceList[i] + "$ \n");
                        i++;
                    }
                }
            }
        }
        public void automobiles()
        {
            Console.WriteLine("Welcome to the Automobile, we have great deals for you!");
            discount = 0.15;
            string[] automobile = new string[10] { "Lexus 320 (2020 Model)", "Mercedes Benz X200", "Honda Accord", "Porsche Spare Tyres", "Masarati Engine Oil", "Lexus 470 HeadLamps", "Toyota Corolla 2019", "Mack Truck Spare Tyres", "Lambourghini Limited 2020 Edition", "Car body spray" };
            double[] automobileOriginalPriceList = new double[10] { 10000, 25000, 4000, 5900, 2000, 8000, 3000, 3000, 500000, 400 };
            Console.WriteLine("Welcome to the Automobile Category, we have great deals for you!");
            if (currentdt == thirdFriday)
            {
                Console.WriteLine("All Products in this category are at a discounted price of 15%(Black Friday Deals!!!)");
                while (i < automobile.Length)
                {
                    double calculatedDiscount = (automobileOriginalPriceList[i] - automobileOriginalPriceList[i] * discount);
                    Console.WriteLine(automobile[i] + "\nPrice -> " + automobileOriginalPriceList[i] + "$ \nDiscounted Price ->" + calculatedDiscount + "$ \n");
                    i++;
                }
            }
            else
            {
                if (currentdt > thirdFriday)
                {
                    Console.WriteLine("Sorry, but you have missed the discount on products in this category");
                    Console.WriteLine("All Products in this category are at their original prices");
                    while (i < automobile.Length)
                    {
                        Console.WriteLine(automobile[i] + "\nPrice -> " + automobileOriginalPriceList[i] + "$ \n");
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("Discount will be on " + thirdFriday.ToString("F"));
                    Console.WriteLine("All Products in this category are at their original prices");
                    while (i < automobile.Length)
                    {
                        Console.WriteLine(automobile[i] + "\nPrice -> " + automobileOriginalPriceList[i] + "$ \n");
                        i++;
                    }
                }
            }
        }
        public void foodHousehold()
        {
            Console.WriteLine("Welcome to the Food and Household Items Category, we have great deals for you!");
            if (currentdt == lastFriday)
            {
                Console.WriteLine("All Products in this category are at a discounted price of 20%");
                Console.WriteLine("Welcome to the Automobile, we have great deals for you!");
                discount = 0.2;
                string[] automobile = new string[10] { "100KG Bag Of Rice", "Carton Of Tasty Tom Tin Tomatoes", "Trailler of Coke", "10 Gallons of Power Oil", "Marbe DinnerWare Set", "Gold Crested Ice cream Cups & Spoons", "Toyota Corolla 2019", "Mack Truck Spare Tyres", "Lambourghini Limited 2020 Edition", "Car body spray" };
                double[] automobileOriginalPriceList = new double[10] { 10000, 25000, 4000, 5900, 2000, 8000, 3000, 3000, 500000, 400 };
                Console.WriteLine("Welcome to the Automobile Category, we have great deals for you!");
                if (currentdt == thirdFriday)
                {
                    Console.WriteLine("All Products in this category are at a discounted price of 15%(Black Friday Deals!!!)");
                    while (i < automobile.Length)
                    {
                        double calculatedDiscount = (automobileOriginalPriceList[i] - automobileOriginalPriceList[i] * discount);
                        Console.WriteLine(automobile[i] + "\nPrice -> " + automobileOriginalPriceList[i] + "$ \nDiscounted Price ->" + calculatedDiscount + "$ \n");
                        i++;
                    }
                }
            }
            else
            {
                if (currentdt > lastFriday)
                {
                    Console.WriteLine("Sorry, but you have missed the discount on products in this category");
                    Console.WriteLine("All Products in this category are at their original prices");
                }
                else
                {
                    Console.WriteLine("All Products in this category are at their original prices");
                    Console.WriteLine("Discount will be on " + lastFriday.ToString("F"));
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BlackFiday day1 = new BlackFiday();
            day1.welcome();
        }
    }
}
