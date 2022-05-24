using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace KTANE_Solver
{
    /// <summary>
    /// Author: Nya Bentley
    /// Purpose: Solves the Cheap Checkout module
    /// </summary>
    public class CheapCheckout : Module
    {

        Item item1;
        Item item2;
        Item item3;
        Item item4;
        Item item5;
        Item item6;

        Decimal amount;

        //used to convert decimals to doubles
        double temp;

        public CheapCheckout(Bomb bomb, StreamWriter logFileWriter,
                             Decimal amount, String item1Name, String item2Name,
                             String item3Name, String item4Name, double item5Weight,
                             String item5Name, double item6Wieght, String item6Name)
        : base(bomb, logFileWriter, "Cheap Checkout")
        {
            item1 = new Item(item1Name, 1);
            item2 = new Item(item2Name, 1);
            item3 = new Item(item3Name, 1);
            item4 = new Item(item4Name, 1);
            item5 = new Item(item5Name, item5Weight);
            item6 = new Item(item6Name, item6Wieght);

            this.amount = amount;
        }

        public void Solve()
        {
            PrintDebugLine("===========================CHEAP CHECKOUT===========================\n");
            


            //print the day
            PrintDebugLine($"Day: {Bomb.Day}\n");

            //print the amount
            PrintDebugLine($"Amount: ${amount}\n");

            //print the items
            PrintItem(item1, 1);
            PrintItem(item2, 2);
            PrintItem(item3, 3);
            PrintItem(item4, 4);
            PrintItem(item5, 5);
            PrintItem(item6, 6);

            PrintDebugLine("==============================After Sale==============================\n");
            
            //apply the sale
            ApplySale();

            //print the items
            PrintItem(item1, 1);
            PrintItem(item2, 2);
            PrintItem(item3, 3);
            PrintItem(item4, 4);
            PrintItem(item5, 5);
            PrintItem(item6, 6);

            //check the total
            Decimal total = RoundPrice(item1.price + item2.price + item3.price + item4.price + item5.price + item6.price);

            PrintDebugLine($"Total: ${total}\n");

            //see if the customer has enough money
            if (amount > total)
            {
                //if yes, tell the user the amount to give back

                decimal answer = RoundPrice(amount - total);

                PrintDebugLine($"Answer: ${answer}\n");

                ShowAnswer($"${string.Format("{0:0.00}", answer)}", true);
            }

            else
            {
                //if not, then tell ther user to alert the customer and tell the new amount
                CheapCheckoutAlertForm alertForm = new CheapCheckoutAlertForm(total, LogFileWriter);

                alertForm.ShowDialog();
            }


        }

        /// <summary>
        /// Prints information about an item
        /// </summary>
        /// <param name="item"></param>
        private void PrintItem(Item item, int num)
        { 
            PrintDebugLine($"Item {num}: {item.name}");

            PrintDebugLine($"Weight: {item.weight}");

            PrintDebugLine($"Price: {item.price}");

            PrintDebugLine($"Category: {item.category}\n");
        }

        /// <summary>
        /// Applies the sale depending on the day of the week
        /// </summary>
        private void ApplySale()
        {

            switch (Bomb.Day)
            {
                case Day.Sunday:
                    //Special Sunday
                    //All fixed price items that contain an S in them are $2.15 more.

                    if (item1.name.ToUpper().Contains('S'))
                        item1.price += 2.15m;

                    if (item2.name.ToUpper().Contains('S'))
                        item2.price += 2.15m;

                    if (item3.name.ToUpper().Contains('S'))
                        item3.price += 2.15m;

                    if (item4.name.ToUpper().Contains('S'))
                        item4.price += 2.15m;
                    break;

                case Day.Monday:
                    //Malleable Monday
                    //The 1st, 3rd and 6th items on the shopping list are 15 % off.

                    item1.price = RoundPrice(item1.price *= .85m);
                    
                    item3.price = RoundPrice(item3.price *= .85m);

                    item6.price = RoundPrice(item6.price *= .85m);


                    break;
                case Day.Tuesday:
                    //Troublesome Tuesday
                    //Calculate the digital root of the item price without the decimal point.
                    //Add that many dollars to the item price. Only applies to fixed price items.

                    item1.price += DigitalRoot(item1.price);
                    item2.price += DigitalRoot(item2.price);
                    item3.price += DigitalRoot(item3.price);
                    item4.price += DigitalRoot(item4.price);

                    break;
                case Day.Wednesday:
                    //Wacky Wednesday
                    //Change each occurrence of the largest digit in the price with the smallest digit
                    //in the price, and vice versa.

                    item1.price = WackyWednesday(item1.price);
                    item2.price = WackyWednesday(item2.price);
                    item3.price = WackyWednesday(item3.price);
                    item4.price = WackyWednesday(item4.price);
                    item5.price = WackyWednesday(item5.price);
                    item6.price = WackyWednesday(item6.price);
                    break;

                case Day.Thursday:
                    //Thrilling Thursday
                    //All of the odd positioned items on the shopping list are half off.

                    item1.price = Convert.ToDecimal(RoundPrice(item1.price /= 2));

                    
                    item3.price = Convert.ToDecimal(RoundPrice(item3.price /= 2));

                    
                    item5.price = Convert.ToDecimal(RoundPrice(item5.price /= 2));


                    break;
                case Day.Friday:
                    //Fruity Friday
                    //All fruits are 25 % more per pound.

                    if (item5.category == Item.Category.Fruit)
                    {
                        temp = Convert.ToDouble(item5.price);
                        item5.price = Convert.ToDecimal(RoundPrice(Convert.ToDecimal(temp *= 1.25 * item5.weight)));
                    }

                    if (item6.category == Item.Category.Fruit)
                    {
                        temp = Convert.ToDouble(item6.price);
                        item5.price = Convert.ToDecimal(RoundPrice(Convert.ToDecimal(temp *= 1.25 * item6.weight)));
                    }

                    break;

                case Day.Saturday:
                    //Sweet Saturday
                    //All sweet items are 35 % off.

                    if (item1.category == Item.Category.Sweet)
                        item1.price = Convert.ToDecimal(RoundPrice(item1.price /= .65m));

                    if (item2.category == Item.Category.Sweet)
                        item2.price = Convert.ToDecimal(RoundPrice(item2.price /= .65m));

                    if (item3.category == Item.Category.Sweet)
                        item3.price = Convert.ToDecimal(RoundPrice(item3.price /= .65m));

                    if (item4.category == Item.Category.Sweet)
                        item4.price = Convert.ToDecimal(RoundPrice(item4.price /= .65m));

                    if (item5.category == Item.Category.Sweet)
                        item5.price = Convert.ToDecimal(RoundPrice(item5.price /= .65m));

                    if (item6.category == Item.Category.Sweet)
                        item6.price = Convert.ToDecimal(RoundPrice(item6.price /= .65m));
                    break;
            }
        }

        private Decimal WackyWednesday(Decimal price)
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

            return Decimal.Parse(newPrice);
        }

        private int DigitalRoot(Decimal price)
        {
            //remove .

            String newPriceString = price.ToString().Replace(".","");

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
        private Decimal RoundPrice(Decimal oldPrice)
        {
            //round the price
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

            public Decimal price;

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
                        price = Convert.ToDecimal(RoundPrice(0.87m, weight));
                        category = Category.Fruit;
                        break;

                    case "Broccoli":
                        price = Convert.ToDecimal(RoundPrice(1.39m, weight));
                        category = Category.Vegetable;
                        break;

                    case "Candy Canes":
                        price = Convert.ToDecimal(RoundPrice(3.51m, weight));
                        category = Category.Sweet;
                        break;

                    case "Canola Oil":
                        price = Convert.ToDecimal(RoundPrice(2.28m, weight));
                        category = Category.Oil;
                        break;

                    case "Cereal":
                        price = Convert.ToDecimal(RoundPrice(4.19m, weight));
                        category = Category.Grain;
                        break;

                    case "Cheese":
                        price = Convert.ToDecimal(RoundPrice(4.49m, weight));
                        category = Category.Dairy;
                        break;

                    case "Chicken":
                        price = Convert.ToDecimal(RoundPrice(1.99m, weight));
                        category = Category.Protein;
                        break;

                    case "Chocolate Bar":
                        price = Convert.ToDecimal(RoundPrice(2.10m, weight));
                        category = Category.Sweet;
                        break;

                    case "Chocolate Milk":
                        price = Convert.ToDecimal(RoundPrice(5.68m, weight));
                        category = Category.Dairy;
                        break;

                    case "Coffee Beans":
                        price = Convert.ToDecimal(RoundPrice(7.85m, weight));
                        category = Category.Other;
                        break;

                    case "Cookies":
                        price = Convert.ToDecimal(RoundPrice(2.00m, weight));
                        category = Category.Sweet;
                        break;

                    case "Deodorant":
                        price = Convert.ToDecimal(RoundPrice(3.97m, weight));
                        category = Category.CareProduct;
                        break;

                    case "Fruit Punch":
                        price = Convert.ToDecimal(RoundPrice(2.08m, weight));
                        category = Category.Sweet;
                        break;

                    case "Grape Jelly":
                        price = Convert.ToDecimal(RoundPrice(2.98m, weight));
                        category = Category.Sweet;
                        break;

                    case "Grapefruit":
                        price = Convert.ToDecimal(RoundPrice(1.08m, weight));
                        category = Category.Fruit;
                        break;

                    case "Gum":
                        price = Convert.ToDecimal(RoundPrice(1.12m, weight));
                        category = Category.Sweet;
                        break;

                    case "Honey":
                        price = Convert.ToDecimal(RoundPrice(8.25m, weight));
                        category = Category.Sweet;
                        break;

                    case "Ketchup":
                        price = Convert.ToDecimal(RoundPrice(3.59m, weight));
                        category = Category.Other;
                        break;

                    case "Lemons":
                        price = Convert.ToDecimal(RoundPrice(1.74m, weight));
                        category = Category.Fruit;
                        break;

                    case "Lettuce":
                        price = Convert.ToDecimal(RoundPrice(1.10m, weight));
                        category = Category.Vegetable;
                        break;

                    case "Lollipops":
                        price = Convert.ToDecimal(RoundPrice(2.61m, weight));
                        category = Category.Sweet;
                        break;

                    case "Lotion":
                        price = Convert.ToDecimal(RoundPrice(7.97m, weight));
                        category = Category.CareProduct;
                        break;

                    case "Mayonnaise":
                        price = Convert.ToDecimal(RoundPrice(3.99m, weight));
                        category = Category.Oil;
                        break;

                    case "Mints":
                        price = Convert.ToDecimal(RoundPrice(6.39m, weight));
                        category = Category.Sweet;
                        break;

                    case "Mustard":
                        price = Convert.ToDecimal(RoundPrice(2.36m, weight));
                        category = Category.Other;
                        break;

                    case "Oranges":
                        price = Convert.ToDecimal(RoundPrice(0.80m, weight));
                        category = Category.Fruit;
                        break;

                    case "Paper Towels":
                        price = Convert.ToDecimal(RoundPrice(9.46m, weight));
                        category = Category.CareProduct;
                        break;

                    case "Pasta Sauce":
                        price = Convert.ToDecimal(RoundPrice(2.30m, weight));
                        category = Category.Vegetable;
                        break;

                    case "Peanut Butter":
                        price = Convert.ToDecimal(RoundPrice(5.00m, weight));
                        category = Category.Protein;
                        break;

                    case "Pork":
                        price = Convert.ToDecimal(RoundPrice(4.14m, weight));
                        category = Category.Protein;
                        break;

                    case "Potato Chips":
                        price = Convert.ToDecimal(RoundPrice(3.25m, weight));
                        category = Category.Oil;
                        break;

                    case "Potatoes":
                        price = Convert.ToDecimal(RoundPrice(0.68m, weight));
                        category = Category.Vegetable;
                        break;

                    case "Shampoo":
                        price = Convert.ToDecimal(RoundPrice(4.98m, weight));
                        category = Category.CareProduct;
                        break;

                    case "Socks":
                        price = Convert.ToDecimal(RoundPrice(6.97m, weight));
                        category = Category.Other;
                        break;

                    case "Soda":
                        price = Convert.ToDecimal(RoundPrice(2.05m, weight));
                        category = Category.Sweet;
                        break;

                    case "Spaghetti":
                        price = Convert.ToDecimal(RoundPrice(2.92m, weight));
                        category = Category.Grain;
                        break;

                    case "Steak":
                        price = Convert.ToDecimal(RoundPrice(4.97m, weight));
                        category = Category.Protein;
                        break;

                    case "Sugar":
                        price = Convert.ToDecimal(RoundPrice(2.08m, weight));
                        category = Category.Sweet;
                        break;

                    case "Tea":
                        price = Convert.ToDecimal(RoundPrice(2.35m, weight));
                        category = Category.Water;
                        break;

                    case "Tissues":
                        price = Convert.ToDecimal(RoundPrice(3.94m, weight));
                        category = Category.CareProduct;
                        break;

                    case "Tomatoes":
                        price = Convert.ToDecimal(RoundPrice(1.80m, weight));
                        category = Category.Fruit;
                        break;

                    case "Toothpaste":
                        price = Convert.ToDecimal(RoundPrice(2.50m, weight));
                        category = Category.CareProduct;
                        break;

                    case "Turkey":
                        price = Convert.ToDecimal(RoundPrice(2.98m, weight));
                        category = Category.Protein;
                        break;

                    case "Water Bottles":
                        price = Convert.ToDecimal(RoundPrice(9.37m, weight));
                        category = Category.Water;
                        break;

                    case "White Bread":
                        price = Convert.ToDecimal(RoundPrice(2.43m, weight));
                        category = Category.Grain;
                        break;

                    case "White Milk":
                        price = Convert.ToDecimal(RoundPrice(3.62m, weight));
                        category = Category.Dairy;
                        break;
                }
            }

            private decimal RoundPrice(decimal amount, double weight)
            {
                return decimal.Round(amount * Convert.ToDecimal(weight), 2, MidpointRounding.AwayFromZero);
            }

            
        }
    }
}
