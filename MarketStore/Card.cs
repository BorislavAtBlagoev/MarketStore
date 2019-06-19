using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Card
    {
        //Fields of class Card.
        private decimal parchaseValue;
        private decimal discountRate;
        private decimal discount;
        private decimal totalSum;

        //Empty constructor 
        public Card()
        {
        }

        //Proparties of class card.
        public string TypeOfCard { get; set; }
        public decimal PurchaseValue
        {
            get => this.parchaseValue;
            set
            {
                if (value >= 0)
                {
                    this.parchaseValue = value;
                }
                else
                {
                    throw new Exception("The value should be higher than 0");
                }
            }
        }
        public decimal DiscountRate
        {
            get => this.discountRate;
            set
            {
                if (value > 0)
                {
                    this.discountRate = value;
                }
            }
        }
        public decimal Discount
        {
            get => this.discount;
            set
            {
                if (value > 0)
                {
                    this.discount = value;
                }
            }
        }
        public decimal TotalSum
        {
            get => this.totalSum;
            set
            {
                if (value > 0)
                {
                    this.totalSum = value;
                }
            }
        }

    }
}
