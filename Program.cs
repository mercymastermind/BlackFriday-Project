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
        string[] Clothing_AccessoryList = new string[10] { "Blue Denim Jacket", "Ferragamo Slip-In Loafers", "Louboutini Red Bottom Heels", "Two-sided Bucket Hats", "Nike Off The Wall", "Brown Fenty Purse", "Fashion Winter Boots", "Off White Winter Coat", "Beluga Necklace", "Men Thick Cuban Chain" };
        double[] Clothing_AccessoryOriginalPriceList = new double[10] { 100, 2000, 4000, 50, 150, 500, 350, 1050, 900, 300 };
        string[] electronicsList = new string[10] { "Samsung A20", "LG 120 inch Solar TV", "Higher Thermocool Electronic Washing Machine", "HP Polaroid 15 inch Gaming Laptop", "Iphone 12 Pro", "Soundless Maxi Generator", "Iphone Earpods", "Tecno Camon 12", "HD Stereo Palma Set", "Touch Sensitive Light Box" };
        double[] electronicsOriginalPriceList = new double[10] { 1000, 2500, 400, 5050, 200, 500, 350, 450, 70, 120 };
        string[] automobile = new string[10] { "Lexus 320 (2020 Model)", "Mercedes Benz X200", "Honda Accord", "Porsche Spare Tyres", "Masarati Engine Oil", "Lexus 470 HeadLamps", "Toyota Corolla 2019", "Mack Truck Spare Tyres", "Lambourghini Limited 2020 Edition", "Car body spray" };
        double[] automobileOriginalPriceList = new double[10] { 10000, 25000, 4000, 5900, 2000, 8000, 3000, 3000, 500000, 400 };
        string[] foodHousehold = new string[10] { "100KG Bag Of Rice", "Carton Of Tasty Tom Tin Tomatoes", "Trailler of Coke", "10 Gallons of Power Oil", "Marbe DinnerWare Set", "Gold Crested Ice cream Cups & Spoons", "Kellog's Corn Flakes", "Skippy Peanut Butter", "Golden Penny Spaghetti", "Golden Morn" };
        double[] foodHouseholdOriginalPriceList = new double[10] { 1000, 2000, 400, 500, 200, 800, 300, 300, 5000, 400 };
        DateTime[] allFridays;
        public enum fridaysOfTheMonth
        {
            firstFriday, secondFriday, thirdFriday, lastFriday
        }

        int option;
        int i;
        double discount;

        public fridaysOfTheMonth CheckFriday(DateTime day)
        {
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
            else
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
            int numDays = DateTime.DaysInMonth(staticDateTime.Year, staticDateTime.Month);
            int index = 0;
            DateTime newDay = new DateTime(staticDateTime.Year, staticDateTime.Month, 01);
            while (numDays > 0)
            {
                if(newDay.DayOfWeek == friday)
                {
                    allFridays[index] = newDay;
                    index++;
                }
                newDay = newDay.AddDays(1);
                numDays--;
            }
        }
        public void optionList()
        {
            Console.WriteLine("On {0}  The Clothing & Accessories Category is on Discount", firstFriday.ToLongDateString());
            Console.WriteLine("On {0}  The Electronic Category is on Discount", secondFriday.ToLongDateString());
            Console.WriteLine("On {0}  The Automobiles Category is on Discount", thirdFriday.ToLongDateString());
            Console.WriteLine("On {0}  The Food & Household Items Category is on Discount", lastFriday.ToLongDateString());
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
                    categoryChoice(Clothing_AccessoryList, Clothing_AccessoryOriginalPriceList);
                    break;

                case 2:
                    Console.WriteLine("Welcome to the Electronics Category, we have great deals for you!");
                    categoryChoice(electronicsList, electronicsOriginalPriceList);
                    break;

                case 3:
                    Console.WriteLine("Welcome to the Automobile, we have great deals for you!");
                    categoryChoice(automobile, automobileOriginalPriceList);
                    break;
                case 4:
                    Console.WriteLine("Welcome to the Food and Household Items Category, we have great deals for you!");
                    categoryChoice(foodHousehold, foodHouseholdOriginalPriceList);
                    break;
                default:
                    Console.WriteLine("Please choose a category between 1-4 ");
                    optionList();
                    break;
            }
        }
        public double getDiscount(fridaysOfTheMonth dt)
        {


            if(dt == fridaysOfTheMonth.firstFriday)
            {
                return 0.05;
            }
            else if(dt == fridaysOfTheMonth.secondFriday)
            {
                return  0.1;
            }
            else if(dt == fridaysOfTheMonth.thirdFriday)
            {
                return 0.15;
            }
            else
            {
                return 0.2;
            }
        }

        //check a date
        public DateTime checkDate(DateTime dt)
        {

            DateTime check = firstFriday;
            while(true)
            {
                if(dt < firstFriday)
                {
                    return firstFriday;
                }
                check = 
            }
        }
        public void categoryChoice(String[] productList, double[] productPriceList[])
        {
            fridaysOfTheMonth dt = CheckFriday(currentdt);
            discount = getDiscount(dt);
            string strDiscount = (discount * 100).ToString();

            Console.WriteLine("Welcome to the Electronics Category, we have great deals for you!");
            discount = 0.1;
            string[] electronicsList = new string[10] { "Samsung A20", "LG 120 inch Solar TV", "Higher Thermocool Electronic Washing Machine", "HP Polaroid 15 inch Gaming Laptop", "Iphone 12 Pro", "Soundless Maxi Generator", "Iphone Earpods", "Tecno Camon 12", "HD Stereo Palma Set", "Touch Sensitive Light Box" };
            double[] electronicsOriginalPriceList = new double[10] { 1000, 2500, 400, 5050, 200, 500, 350, 450, 70, 120 };
            Console.WriteLine("Welcome to the Electronics Category, we have great deals for you!");
            if (currentdt == secondFriday)
            {
                Console.WriteLine("All Products in this category are at a discounted price of 10%(Black Friday Deals!!!)");
                while (i < electronicsList.Length)
                {
                    double calculatedDiscount = (electronicsOriginalPriceList[i] - electronicsOriginalPriceList[i] * discount);
                    Console.WriteLine(electronicsList[i] + "\nPrice -> " + electronicsOriginalPriceList[i] + "$ \nDiscounted Price ->" + calculatedDiscount + "$ \n");
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
                    Console.WriteLine("Discount for this Category will be on " + secondFriday.ToLongDateString());
                    Console.WriteLine("All Products in this category are at their original prices");
                    while (i < electronicsList.Length)
                    {

                        Console.WriteLine(electronicsList[i] + "\nPrice -> " + electronicsOriginalPriceList[i] + "$ \n");
                        i++;
                    }
                }
            }
        }
        
        static void Main(string[] args)
        {
            
        }
    }
}
