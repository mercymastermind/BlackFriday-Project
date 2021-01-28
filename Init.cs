using System;

namespace Black_Friday
{
    class BlackFiday
    {
        //  the current user date is chosen here
        static DateTime staticDateTime = DateTime.Parse("2021-01-29");

        //  the hardcoded items for each category
        string[] CLOTHING_ACCESSORIES = new string[10] { "Blue Denim Jacket", "Ferragamo Slip-In Loafers", "Louboutini Red Bottom Heels", "Two-sided Bucket Hats", "Nike Off The Wall", "Brown Fenty Purse", "Fashion Winter Boots", "Off White Winter Coat", "Beluga Necklace", "Men Thick Cuban Chain" };
        double[] CLOTHING_ACCESSORIES_PRICES = new double[10] { 100, 2000, 4000, 50, 150, 500, 350, 1050, 900, 300 };
        string[] ELECTRONICS = new string[10] { "Samsung A20", "LG 120 inch Solar TV", "Higher Thermocool Electronic Washing Machine", "HP Polaroid 15 inch Gaming Laptop", "Iphone 12 Pro", "Soundless Maxi Generator", "Iphone Earpods", "Tecno Camon 12", "HD Stereo Palma Set", "Touch Sensitive Light Box" };
        double[] ELECTRONICS_PRICES = new double[10] { 1000, 2500, 400, 5050, 200, 500, 350, 450, 70, 120 };
        string[] AUTOMOBILE = new string[10] { "Lexus 320 (2020 Model)", "Mercedes Benz X200", "Honda Accord", "Porsche Spare Tyres", "Masarati Engine Oil", "Lexus 470 HeadLamps", "Toyota Corolla 2019", "Mack Truck Spare Tyres", "Lambourghini Limited 2020 Edition", "Car body spray" };
        double[] AUTOMOBILE_PRICES = new double[10] { 10000, 25000, 4000, 5900, 2000, 8000, 3000, 3000, 500000, 400 };
        string[] FOOD_HOUSEHOLD = new string[10] { "100KG Bag Of Rice", "Carton Of Tasty Tom Tin Tomatoes", "Trailler of Coke", "10 Gallons of Power Oil", "Marbe DinnerWare Set", "Gold Crested Ice cream Cups & Spoons", "Kellog's Corn Flakes", "Skippy Peanut Butter", "Golden Penny Spaghetti", "Golden Morn" };
        double[] FOOD_HOUSEHOLD_PRICES = new double[10] { 1000, 2000, 400, 500, 200, 800, 300, 300, 5000, 400 };

        //  an instance of all the categories this app supports
        static Array allCategories = Array.CreateInstance(typeof(Category), 4);

        //  an instance of the FridayUtil class for tasks associated with the day,  Friday 
        FridayUtil tempFridayUtil;

        //  a global discount variable to indicate the discount across all categories
        double discount;

        //  variable to hold all the fridays in a month
        DateTime[] allFridays;

        //  array of all harcoded discounts available in a month
        double[] discounts = { 0.05, 0.1, 0.15, 0.2, 0.25};

        //  called at startup   -   generates all the categories,with their products and prices. Generates all the fridays for that month.
        private void setUp()
        {
            allCategories.SetValue(Category.createInstance("Clothing and Accessories", CLOTHING_ACCESSORIES, CLOTHING_ACCESSORIES_PRICES, 10), 0);
            allCategories.SetValue(Category.createInstance("Electronics", ELECTRONICS, ELECTRONICS_PRICES, 10), 1);
            allCategories.SetValue(Category.createInstance("Automobile", AUTOMOBILE, AUTOMOBILE_PRICES, 10), 2);
            allCategories.SetValue(Category.createInstance("Food and Household", FOOD_HOUSEHOLD, FOOD_HOUSEHOLD_PRICES, 10), 3);
            tempFridayUtil = new FridayUtil(staticDateTime);
            allFridays = tempFridayUtil.allFridays;
        }



        //  start the program
        public void init()
        {
            Console.WriteLine("\nWelcome To the biggest sales in Africa, Black Friday!");
            Console.WriteLine("\nBelow are the lists of the black fridays and the discounts available on those days");
            setUp();
            printDiscounts();
            optionList();
        }

        //  prints all the discounts available for the fridays in the chosen month
        public void printDiscounts()
        {
            for (int i = 0; i < allFridays.Length; i++)
            {
                if(!allFridays[i].Date.Equals(DateTime.Parse("0001-01-01")))
                {
                    Console.WriteLine("\nOn {0}, The Discount is {1}%", allFridays[i].ToLongDateString(), discounts[i] * 100);
                }
            }
        }

        //  prints all categories for user to pick from and parses user choice
        public void optionList()
        {
            restart:
            Console.WriteLine("\nWhat Category would you like to Shop from?");
            Console.WriteLine("\nEnter 1 for Clothing and Accessories\n" +
                "Enter 2 for Electronics\n" +
                "Enter 3 for Automobiles\n" +
                "Enter 4 for Food & Household Items\n" + 
                "Enter 5 to Exit");

            Console.WriteLine("\nYour Choice: ");
            int userChoice = 0;

            try
            {
               userChoice = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid choice! Please try again!");
                goto restart;
            }

            optionChoice(userChoice);
        }

        //  handles user choice and calls appropriate category where necessary
        public void optionChoice(int userChoice)
        {
            Category temp;

            if(userChoice > 0 && userChoice <= 4)
            {
                temp = (Category)allCategories.GetValue(userChoice - 1);
                Console.WriteLine($"\nWelcome to the {temp.getName()} Category, we have great deals for you!");
                categoryChoice(temp);
                optionList();
            }

            else if(userChoice == 5)
            {
                Console.WriteLine("\nThank you and Have a good day!");
            }
            
            else 
            {
                Console.WriteLine("Invalid choice! Please try again!");
                optionList();
            }
        }

        //  returns appropriate discount based on the friday of the month
        public double getDiscount(FridayUtil.fridaysOfTheMonth dt)
        {
            if(dt == FridayUtil.fridaysOfTheMonth.firstFriday)
            {
                return 0.05;
            }
            else if(dt == FridayUtil.fridaysOfTheMonth.secondFriday)
            {
                return  0.1;
            }
            else if(dt == FridayUtil.fridaysOfTheMonth.thirdFriday)
            {
                return 0.15;
            }
            else if (dt == FridayUtil.fridaysOfTheMonth.fourthFriday)
            {
                return 0.2;
            }
            else
            {
                return 0.25;
            }
        }

        //  prints products in category and displays appropriate discount for category if necessary. 
        //  Handles no discount scenario.
        public void categoryChoice(Category cat)
        {
            string strDiscount;

            if (FridayUtil.isFriday(staticDateTime))
            {
                FridayUtil.fridaysOfTheMonth dt = tempFridayUtil.CheckFriday(staticDateTime);
                discount = getDiscount(dt);
            }

            else
            {
                discount = 0;
            }

            strDiscount = (discount * 100).ToString();

            int i = 0;
            if(discount == 0)
            {
                Console.WriteLine("All Products in this category are not discounted!)");
                Console.WriteLine("Discount for this Category will be on " + tempFridayUtil.getNearestFriday(staticDateTime));
            }
            else
            {
                Console.WriteLine("All Products in this category are at a discounted price of {0}%(Black Friday Deals!!!)\n", strDiscount);
            }

            Array categoryProductNames = cat.getProductNames();
            Array categoryProductPrices = cat.getProductPrices();

            Console.WriteLine("Here are our Products for the day!\n");

            while (i < categoryProductNames.Length)
            {
                double calculatedDiscount = ((double)categoryProductPrices.GetValue(i) - ((double)categoryProductPrices.GetValue(i) * discount));
                //Console.WriteLine(productList[i] + "\nPrice -> {}", productPriceList[i]);
                Console.WriteLine($"{categoryProductNames.GetValue(i)} \nPrice {categoryProductPrices.GetValue(i)}");
                if (discount != 0)
                {
                    Console.Write($"Discounted Price -> {calculatedDiscount}\n\n");
                }
                i++;
            }
        }
        
        static void Main(string[] args)
        {
            BlackFiday blackFiday = new BlackFiday();
            blackFiday.init();
        }
    }
}
