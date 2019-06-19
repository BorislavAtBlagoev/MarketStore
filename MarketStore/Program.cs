using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enters value for the turnover and guaranteed that it is not negative.
            Console.WriteLine("Please enter the turnover for the previous month:");
            decimal turnover = decimal.Parse(Console.ReadLine());
            while (turnover < 0)
            {
                Console.WriteLine("The turnover should be higher than 0");
                turnover = decimal.Parse(Console.ReadLine());
            }

            //Enters value for the purchase value.
            Console.WriteLine("Please enter the purchase value:");
            decimal purchaseValue = decimal.Parse(Console.ReadLine());

            //Chooses which kind of card we prefer.
            Console.WriteLine("Please enter the type of discount card:");
            string typeOfCard = Console.ReadLine();
            while (!(typeOfCard == "Bronze" || typeOfCard == "Silver" || typeOfCard == "Gold"))
            {
                Console.WriteLine("Invalid discount card type. Please choose between following: Bronze, Silver and Gold");
                typeOfCard = Console.ReadLine();
            }

            if (typeOfCard == "Bronze")
            {
                //If we choose bronze card ,the program comes here.
                Bronze bronzeCard = new Bronze();
                bronzeCard.BronzCardDiscount(turnover, purchaseValue);
                PayDesk.Print(bronzeCard.PurchaseValue, bronzeCard.DiscountRate, bronzeCard.Discount, bronzeCard.TotalSum, bronzeCard.TypeOfCard);
            }
            else if (typeOfCard == "Silver")
            {
                //If we choose silver card ,the program comes here.
                Silver silverCard = new Silver();
                silverCard.SilverCardDiscount(turnover, purchaseValue);
                PayDesk.Print(silverCard.PurchaseValue, silverCard.DiscountRate, silverCard.Discount, silverCard.TotalSum, silverCard.TypeOfCard);
            }
            else if (typeOfCard == "Gold")
            {
                //If we choose gold card ,the program comes here.
                Gold goldCard = new Gold();
                goldCard.GoldCardDiscount(turnover, purchaseValue);
                PayDesk.Print(goldCard.PurchaseValue, goldCard.DiscountRate, goldCard.Discount, goldCard.TotalSum, goldCard.TypeOfCard);
            }
        }
    }
}
