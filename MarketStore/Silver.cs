using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    //Inheritance the class Card.
    public class Silver : Card
    {
        //Constructor that sets the value of TypeOfCard.
        public Silver()
        {
            TypeOfCard = "Silver";
        }

        //Method for silver card discount.
        public void SilverCardDiscount(decimal turnover, decimal purchaseValue)
        {
            if (turnover > 300)
            {
                PurchaseValue = purchaseValue;
                DiscountRate = 3.5m;
                Discount = (PurchaseValue / 100) * DiscountRate;
                TotalSum = PurchaseValue - Discount;
            }
            else if(turnover <= 300)
            {
                PurchaseValue = purchaseValue;
                DiscountRate = 2m;
                Discount = (PurchaseValue / 100) * DiscountRate;
                TotalSum = PurchaseValue - Discount;
            }
        }
    }
}
