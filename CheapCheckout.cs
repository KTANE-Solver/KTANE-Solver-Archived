using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    public class CheapCheckout : Module
    {

        Item item1;
        Item item2;
        Item item3;
        Item item4;
        Item item5;
        Item item6;

        double amount;

        public CheapCheckout(Bomb bomb, StreamWriter logFileWriter,
                             double amount, String item1Name, String item2Name,
                             String item3Name, String item4Name, int item5Weight,
                             String item5Name, int item6Wieght, String item6Name) : base(bomb, logFileWriter)
        {
            item1 = new Item(item1Name, 1);
            item2 = new Item(item2Name, 1);
            item3 = new Item(item3Name, 1);
            item4 = new Item(item4Name, 1);
            item5 = new Item(item5Name, item5Weight);
            item6 = new Item(item6Name, item6Wieght);

            this.amount = amount;
        }

        private void Solve()
        { 
            
        }

        /// <summary>
        /// Applies the sale depending on the day of the week
        /// </summary>
        private void ApplySale()
        {

            switch (Bomb.Day)
            {
                case Bomb.Days.Sunday:
                    //Special Sunday
                    //All fixed price items that contain an S in them are $2.15 more.

                    if (item1.name.ToUpper().Contains('S'))
                        item1.price += 2.15;

                    if (item2.name.ToUpper().Contains('S'))
                        item2.price += 2.15;

                    if (item3.name.ToUpper().Contains('S'))
                        item3.price += 2.15;

                    if (item4.name.ToUpper().Contains('S'))
                        item4.price += 2.15;

                    if (item5.name.ToUpper().Contains('S'))
                        item5.price += 2.15;

                    if (item6.name.ToUpper().Contains('S'))
                        item6.price += 2.15;
                    break;

                case Bomb.Days.Monday:
                    //Malleable Monday
                    //The 1st, 3rd and 6th items on the shopping list are 15 % off.

                    item1.price = RoundPrice(item1.price /= .85);
                    
                    item3.price = RoundPrice(item3.price /= .85);

                    item6.price = RoundPrice(item6.price /= .85);


                    break;
                case Bomb.Days.Tuesday:
                    //Troublesome Tuesday
                    //Calculate the digital root of the item price without the decimal point.
                    //Add that many dollars to the item price. Only applies to fixed price items.

                    item1.price += DigitalRoot(item1.price);
                    item2.price += DigitalRoot(item2.price);
                    item3.price += DigitalRoot(item3.price);
                    item4.price += DigitalRoot(item4.price);

                    break;
                case Bomb.Days.Wednesday:
                    //Wacky Wednesday
                    //Change each occurrence of the largest digit in the price with the smallest digit
                    //in the price, and vice versa.

                    item1.price = WackyWedmesday(item1.price);
                    item2.price = WackyWedmesday(item2.price);
                    item3.price = WackyWedmesday(item3.price);
                    item4.price = WackyWedmesday(item4.price);
                    item5.price = WackyWedmesday(item5.price);
                    item6.price = WackyWedmesday(item6.price);
                    break;

                case Bomb.Days.Thursday:
                    //Thrilling Thursday
                    //All of the odd positioned items on the shopping list are half off.

                    item1.price = RoundPrice(item1.price *= .5);

                    
                    item3.price = RoundPrice(item3.price *= .5);

                    
                    item5.price = RoundPrice(item5.price *= .5);


                    break;
                case Bomb.Days.Friday:
                    //Fruity Friday
                    //All fruits are 25 % more per pound.

                    if (item5.category == Item.Category.Fruit)
                        item5.price = RoundPrice(item5.price *= 1.25 * item5.weight);

                    if (item6.category == Item.Category.Fruit)
                        item6.price = RoundPrice(item6.price *= 1.25 * item6.weight);

                    break;
                case Bomb.Days.Saturday:
                    //Sweet Saturday
                    //All sweet items are 35 % off.

                    if (item1.category == Item.Category.Sweet)
                        item1.price = RoundPrice(item1.price /= .65);

                    if (item2.category == Item.Category.Sweet)
                        item2.price = RoundPrice(item2.price /= .65);

                    if (item3.category == Item.Category.Sweet)
                        item3.price = RoundPrice(item3.price /= .65);

                    if (item4.category == Item.Category.Sweet)
                        item4.price = RoundPrice(item4.price /= .65);

                    if (item5.category == Item.Category.Sweet)
                        item5.price = RoundPrice(item5.price /= .65);

                    if (item6.category == Item.Category.Sweet)
                        item6.price = RoundPrice(item6.price /= .65);
                    break;
            }
        }

        private double WackyWedmesday(double price)
        {
            //convert price to string
            String priceString = ("" + price);

            //find highest value

            char highestDigit = priceString[0];

            for (int i = 1; i < priceString.Length; i++)
            {
                char currentChar = priceString[i];

                //highest character can't be '.'
                if (currentChar == '.')
                {
                    continue;
                }

                if (highestDigit < currentChar)
                {
                    highestDigit = currentChar;
                }
            }

            //find the lowest digit

            char lowestDigit = priceString[0];

            for (int i = 1; i < priceString.Length; i++)
            {
                //lowest digit can't be '.'
                if (lowestDigit == '.')
                {
                    lowestDigit = priceString[i];
                }

                char currentChar = priceString[i];

                //lowest digit can't be '.'
                if (currentChar == '.')
                {
                    continue;
                }

                if (lowestDigit > currentChar)
                {
                    lowestDigit = currentChar;
                }
            }

            String newPrice = "";

            //for every place with the lowest digit, swap it with the highest digit

            //for every place with the highest digit, swap it with the lowest digit

            for (int i = 0; i < priceString.Length; i++)
            {
                char currentChar = priceString[i];

                if (currentChar == highestDigit)
                    newPrice += lowestDigit;

                else if (currentChar == lowestDigit)
                    newPrice += highestDigit;

                else
                    newPrice += priceString[i];
            }

            //insert the .

            newPrice.Insert(priceString.IndexOf('.'), ".");

            //parse the price and return

            return Double.Parse(newPrice);
        }

        private int DigitalRoot(double price)
        {
            //remove .

            String newPriceString = ("" + price).Replace('.', '');

            //convert to int

            int newPrice = Int32.Parse(newPriceString);

            int root = 0;

            // Loop to do sum while
            // sum is not less than
            // or equal to 9
            while (newPrice > 0 || root > 9)
            {
                if (newPrice == 0)
                {
                    newPrice = root;
                    root = 0;
                }

                root += newPrice % 10;
                newPrice /= 10;
            }
            return root;

        }

        /// <summary>
        /// Rounds the price always up to 2 decimals
        /// </summary>
        private double RoundPrice(double oldPrice)
        {
            return Math.Round(oldPrice, 2, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Represents each item
        /// </summary>
        public class Item
        {
            //The category each item can fits into
            public enum Category
            { 
                CareProduct,
                Dairy,
                Fruit,
                Grain,
                Protein,
                Oil,
                Other,
                Sweet,
                Vegetable,
                Water
            }

            public String name;

            public double price;

            public double weight;

            public Category category;

            public Item(String name, double weight)
            {
                this.name = name;
                this.weight = weight;

                //set up price and category
                switch (name)
                {
                    case "Bananas":
                        price = RoundPrice(0.87, weight);
                        category = Category.Fruit;
                        break;

                    case "Broccoli":
                        price = RoundPrice(1.39, weight);
                        category = Category.Vegetable;
                        break;

                    case "Candy Canes":
                        price = RoundPrice(3.51, weight);
                        category = Category.Sweet;
                        break;

                    case "Canola Oil":
                        price = RoundPrice(2.28, weight);
                        category = Category.Oil;
                        break;

                    case "Cereal":
                        price = RoundPrice(4.19, weight);
                        category = Category.Grain;
                        break;

                    case "Cheese":
                        price = RoundPrice(4.49, weight);
                        category = Category.Dairy;
                        break;

                    case "Chicken":
                        price = RoundPrice(1.99, weight);
                        category = Category.Protein;
                        break;

                    case "Chocolate Bar":
                        price = RoundPrice(2.10, weight);
                        category = Category.Sweet;
                        break;

                    case "Chocolate Milk":
                        price = RoundPrice(5.68, weight);
                        category = Category.Dairy;
                        break;

                    case "Coffee Beans":
                        price = RoundPrice(7.85, weight);
                        category = Category.Other;
                        break;

                    case "Cookies":
                        price = RoundPrice(2.00, weight);
                        category = Category.Sweet;
                        break;

                    case "Deodorant":
                        price = RoundPrice(3.97, weight);
                        category = Category.CareProduct;
                        break;

                    case "Fruit Punch":
                        price = RoundPrice(2.08, weight);
                        category = Category.Sweet;
                        break;

                    case "Grape Jelly":
                        price = RoundPrice(2.98, weight);
                        category = Category.Sweet;
                        break;

                    case "Grapefruit":
                        price = RoundPrice(1.08, weight);
                        category = Category.Fruit;
                        break;

                    case "Gum":
                        price = RoundPrice(1.12, weight);
                        category = Category.Sweet;
                        break;

                    case "Honey":
                        price = RoundPrice(8.25, weight);
                        category = Category.Sweet;
                        break;

                    case "Ketchup":
                        price = RoundPrice(3.59, weight);
                        category = Category.Other;
                        break;

                    case "Lemons":
                        price = RoundPrice(1.74, weight);
                        category = Category.Fruit;
                        break;

                    case "Lettuce":
                        price = RoundPrice(1.10, weight);
                        category = Category.Vegetable;
                        break;

                    case "Lollipops":
                        price = RoundPrice(2.61, weight);
                        category = Category.Sweet;
                        break;

                    case "Lotion":
                        price = RoundPrice(7.97, weight);
                        category = Category.CareProduct;
                        break;

                    case "Mayonnaise":
                        price = RoundPrice(3.99, weight);
                        category = Category.Oil;
                        break;

                    case "Mints":
                        price = RoundPrice(6.39, weight);
                        category = Category.Sweet;
                        break;

                    case "Mustard":
                        price = RoundPrice(2.36, weight);
                        category = Category.Other;
                        break;

                    case "Oranges":
                        price = RoundPrice(.80, weight);
                        category = Category.Fruit;
                        break;

                    case "Paper Towels":
                        price = RoundPrice(9.46, weight);
                        category = Category.CareProduct;
                        break;

                    case "Pasta Sauce":
                        price = RoundPrice(2.30, weight);
                        category = Category.Vegetable;
                        break;

                    case "Peanut Butter":
                        price = RoundPrice(5, weight);
                        category = Category.Protein;
                        break;

                    case "Pork":
                        price = RoundPrice(4.14, weight);
                        category = Category.Protein;
                        break;

                    case "Potato Chips":
                        price = RoundPrice(3.25, weight);
                        category = Category.Oil;
                        break;

                    case "Potatoes":
                        price = RoundPrice(.68, weight);
                        category = Category.Vegetable;
                        break;

                    case "Shampoo":
                        price = RoundPrice(4.98, weight);
                        category = Category.CareProduct;
                        break;

                    case "Socks":
                        price = RoundPrice(6.97, weight);
                        category = Category.Other;
                        break;

                    case "Soda":
                        price = RoundPrice(2.05, weight);
                        category = Category.Sweet;
                        break;

                    case "Spaghetti":
                        price = RoundPrice(2.92, weight);
                        category = Category.Grain;
                        break;

                    case "Steak":
                        price = RoundPrice(4.97, weight);
                        category = Category.Protein;
                        break;

                    case "Sugar":
                        price = RoundPrice(2.08, weight);
                        category = Category.Sweet;
                        break;

                    case "Tea":
                        price = RoundPrice(2.35, weight);
                        category = Category.Water;
                        break;

                    case "Tissues":
                        price = RoundPrice(3.94, weight);
                        category = Category.CareProduct;
                        break;

                    case "Tomatoes":
                        price = RoundPrice(1.8, weight);
                        category = Category.Fruit;
                        break;

                    case "Toothpaste":
                        price = RoundPrice(2.5, weight);
                        category = Category.CareProduct;
                        break;

                    case "Turkey":
                        price = RoundPrice(2.98, weight);
                        category = Category.Water;
                        break;

                    case "Water Bottles":
                        price = RoundPrice(9.37, weight);
                        category = Category.Water;
                        break;

                    case "White Bread":
                        price = RoundPrice(2.43, weight);
                        category = Category.Grain;
                        break;

                    case "White Milk":
                        price = RoundPrice(3.62, weight);
                        category = Category.Dairy;
                        break;
                }
            }

            private double RoundPrice(double amount, double weight)
            {
                return Math.Round(amount * weight, 2, MidpointRounding.AwayFromZero);
            }

            
        }
    }
}
