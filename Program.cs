using System;

namespace Black_Friday
{
    class BlackFiday
    {
        DayOfWeek friday = DayOfWeek.Friday;
        static DateTime staticDateTime = DateTime.Now;
        DateTime currentdt = staticDateTime;
        string[] CLOTHING_ACCESSORIES = new string[10] { "Blue Denim Jacket", "Ferragamo Slip-In Loafers", "Louboutini Red Bottom Heels", "Two-sided Bucket Hats", "Nike Off The Wall", "Brown Fenty Purse", "Fashion Winter Boots", "Off White Winter Coat", "Beluga Necklace", "Men Thick Cuban Chain" };
        double[] CLOTHING_ACCESSORIES_PRICES = new double[10] { 100, 2000, 4000, 50, 150, 500, 350, 1050, 900, 300 };
        string[] ELECTRONICS = new string[10] { "Samsung A20", "LG 120 inch Solar TV", "Higher Thermocool Electronic Washing Machine", "HP Polaroid 15 inch Gaming Laptop", "Iphone 12 Pro", "Soundless Maxi Generator", "Iphone Earpods", "Tecno Camon 12", "HD Stereo Palma Set", "Touch Sensitive Light Box" };
        double[] ELECTRONICS_PRICES = new double[10] { 1000, 2500, 400, 5050, 200, 500, 350, 450, 70, 120 };
        string[] AUTOMOBILE = new string[10] { "Lexus 320 (2020 Model)", "Mercedes Benz X200", "Honda Accord", "Porsche Spare Tyres", "Masarati Engine Oil", "Lexus 470 HeadLamps", "Toyota Corolla 2019", "Mack Truck Spare Tyres", "Lambourghini Limited 2020 Edition", "Car body spray" };
        double[] AUTOMOBILE_PRICES = new double[10] { 10000, 25000, 4000, 5900, 2000, 8000, 3000, 3000, 500000, 400 };
        string[] FOOD_HOUSEHOLD = new string[10] { "100KG Bag Of Rice", "Carton Of Tasty Tom Tin Tomatoes", "Trailler of Coke", "10 Gallons of Power Oil", "Marbe DinnerWare Set", "Gold Crested Ice cream Cups & Spoons", "Kellog's Corn Flakes", "Skippy Peanut Butter", "Golden Penny Spaghetti", "Golden Morn" };
        double[] FOOD_HOUSEHOLD_PRICES = new double[10] { 1000, 2000, 400, 500, 200, 800, 300, 300, 5000, 400 };
        DateTime[] allFridays = new DateTime[5];
        static Array allCategories = Array.CreateInstance(typeof(Category), 4);

        private void getFridays()
        {
            int numDays = DateTime.DaysInMonth(staticDateTime.Year, staticDateTime.Month);
            int index = 0;
            DateTime newDay = new DateTime(staticDateTime.Year, staticDateTime.Month, 01);
            while (numDays > 0)
            {
                if (newDay.DayOfWeek == friday)
                {
                    allFridays[index] = newDay;
                    index++;
                }
                newDay = newDay.AddDays(1);
                numDays--;
            }
        }

        private void setUp()
        {
            allCategories.SetValue(Category.createInstance("Clothing and Accessories", CLOTHING_ACCESSORIES, CLOTHING_ACCESSORIES_PRICES, 10), 0);
            allCategories.SetValue(Category.createInstance("Electronics", ELECTRONICS, ELECTRONICS_PRICES, 10), 1);
            allCategories.SetValue(Category.createInstance("Automobile", AUTOMOBILE, AUTOMOBILE_PRICES, 10), 2);
            allCategories.SetValue(Category.createInstance("Food and Household", CLOTHING_ACCESSORIES, CLOTHING_ACCESSORIES_PRICES, 10), 3);
        }

        

        public enum fridaysOfTheMonth
        {
            firstFriday, secondFriday, thirdFriday, lastFriday
        }

        int option;
        int i;
        double discount;

        //  check which friday it is.
        public fridaysOfTheMonth CheckFriday(DateTime day)
        {
            if(day == allFridays[0])
            {
                return fridaysOfTheMonth.firstFriday;
            }
            else if (day == allFridays[1])
            {
                return fridaysOfTheMonth.secondFriday;
            }
            else if (day == allFridays[2])
            {
                return fridaysOfTheMonth.thirdFriday;
            }
            else
            {
                return fridaysOfTheMonth.lastFriday;
            }
        }

        public bool isFriday(DateTime dt)
        {
            return dt.DayOfWeek == DayOfWeek.Friday;
        }

        //  start the program
        public void welcome()
        {
            Console.WriteLine("Welcome To the biggest sales in Africa, Black Friday!");
            Console.WriteLine("Below are the lists of the black fridays and the categories of products with discounts on those days");
            setUp();
            optionList();
        }

        public void optionList()
        {
            Console.WriteLine("On {0}  The Clothing & Accessories Category is on Discount", allFridays[0].ToLongDateString());
            Console.WriteLine("On {0}  The Electronic Category is on Discount", allFridays[1].ToLongDateString());
            Console.WriteLine("On {0}  The Automobiles Category is on Discount", allFridays[2].ToLongDateString());
            Console.WriteLine("On {0}  The Food & Household Items Category is on Discount", allFridays[3].ToLongDateString());
            Console.WriteLine("What Category would you like to Shop from?");
            Console.WriteLine("Enter 1 for Clothing and Accessories\n" +
                "Enter 2 for Electronics\n" +
                "Enter 3 for Automobiles\n" +
                "Enter 4 for Food & Household Items");
            int userChoice = Convert.ToInt16(Console.ReadLine());
            optionChoice(userChoice);
        }

        public void optionChoice(int userChoice)
        {
            Category temp;

            if(userChoice > 0 && userChoice <= 4)
            {
                temp = (Category)allCategories.GetValue(userChoice - 1);
                Console.WriteLine($"Welcome to the {temp.getName()} Category, we have great deals for you!");
                categoryChoice(temp);
            }
            
            else
            {
                Console.WriteLine("Invalid choice! Please try again!");
                optionList();
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

        public DateTime getNearestFriday(DateTime dt)
        {
            DateTime upperFriday = allFridays[0].AddYears(1);
            for(int i = 0; i < allFridays.Length; i++)
            {
                if(dt <= allFridays[i])
                {
                    upperFriday = allFridays[i];
                    break;
                }
            }
            return upperFriday;
        }
        public void categoryChoice(Category cat)
        {
            string strDiscount;

            if (isFriday(currentdt))
            {
                fridaysOfTheMonth dt = CheckFriday(currentdt);
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
                Console.WriteLine("Discount for this Category will be on " + getNearestFriday(currentdt));
            }
            else
            {
                Console.WriteLine("All Products in this category are at a discounted price of {0}%(Black Friday Deals!!!)", strDiscount);
            }

            Array categoryProductNames = cat.getProductNames();

            while (i < categoryProductNames.Length)
            {
                double calculatedDiscount = (categoryProductNames.GetValue(i) - productPriceList[i] * discount);
                //Console.WriteLine(productList[i] + "\nPrice -> {}", productPriceList[i]);
                Console.WriteLine($"{productList[i]} \nPrice {productPriceList[i]}");
                if (discount != 0)
                {
                    Console.Write($"\nDiscounted Price -> {calculatedDiscount * productPriceList[i]}");
                }
                i++;
            }
        }
        
        static void Main(string[] args)
        {
            BlackFiday blackFiday = new BlackFiday();
            blackFiday.welcome();
        }
    }
}
