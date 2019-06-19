using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class PayDesk
    {
        //Method for printing the final result.
        public static void Print(decimal parchaseValue, decimal discountRate, decimal discount, decimal totalSum, string typeOfCard)
        {
            //I used a stringbuilder because the concatenation is a slow operation.
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nYou chose {typeOfCard} card \n");
            sb.Append($"Purchase value: ${parchaseValue:f2} \n");
            sb.Append($"Discount rate: {discountRate:f1}% \n");
            sb.Append($"Discount: ${discount:f2} \n");
            sb.Append($"Total: ${totalSum:f2} \n");
            Console.WriteLine(sb);
        }
    }
}
