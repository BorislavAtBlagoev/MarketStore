using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    //Inheritance the class Card.
    public class Gold : Card
    {
        //Constructor that sets the value of TypeOfCard.
        public Gold()
        {
            TypeOfCard = "Gold";
        }

        //Method for gold card discount.
        public void GoldCardDiscount(decimal turnover, decimal purchaseValue)
        {
            if (turnover < 100)
            {
                PurchaseValue = purchaseValue;
                DiscountRate = 2m;
                Discount = (PurchaseValue / 100) * DiscountRate;
                TotalSum = PurchaseValue - Discount;
            }
            else if (turnover >= 100)
            {
                int turnoverAsInt = Decimal.ToInt32(turnover);
                if (turnover >= 1000)
                {
                    turnoverAsInt = 8;
                }
                else
                {
                    while (turnoverAsInt >= 10)
                    {
                        turnoverAsInt /= 10;
                    }
                }

                PurchaseValue = purchaseValue;
                DiscountRate = turnoverAsInt+2;
                Discount = (PurchaseValue / 100) * DiscountRate;
                TotalSum = PurchaseValue - Discount;
            }
        }
    }
}
