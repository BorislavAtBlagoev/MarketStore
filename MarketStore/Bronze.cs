using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    //Inheritance the class Card.
    public class Bronze : Card
    {
        //Constructor that sets the value of TypeOfCard.
        public Bronze()
        {
            TypeOfCard = "Bronze";
        }

        //Method for bronze card discount.
        public void BronzCardDiscount(decimal turnover, decimal purchaseValue)
        {
            if (turnover >= 100 && turnover <= 300)
            {
                PurchaseValue = purchaseValue;
                DiscountRate = 1m;
                Discount = (PurchaseValue / 100) * DiscountRate;
                TotalSum = PurchaseValue - Discount;
            }
            else if (turnover > 300)
            {
                PurchaseValue = purchaseValue;
                DiscountRate = 2.5m;
                Discount = (PurchaseValue / 100) * DiscountRate;
                TotalSum = PurchaseValue - Discount;
            }
            else if (turnover < 100)
            {
                PurchaseValue = purchaseValue;
                DiscountRate = 0m;
                Discount = 0;
                TotalSum = PurchaseValue;
            }
        }
    }
}
