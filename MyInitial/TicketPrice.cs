﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private bool discount;
        private bool isChild;
        private decimal amountDue;
        private decimal mPrice;

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
        const decimal mdecDiscount = 5.0m;
        const decimal mdecDiscountChild = 10.0m;
        const decimal mdecStall = 15.0m;
      //  const decimal mdecDiscount = 5.0m; 

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

         private bool Discount
        {
            get { return discount; }
            set { discount = value; }
        }
          private bool IsChild // Added property
        {
            get { return isChild; }
            set { isChild = value; }
        }
        public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

    // Constructor for TcicketPrice
    public TicketPrice(int section, int quantity, bool discount, bool isChild)
    {
        Section = section;
        Quantity = quantity;
        Discount = discount;
         IsChild = isChild;
         AmountDue = amountDue;
    }

     public void calculatePrice()
     {

         switch (section)
         {
             case 1:
                 mPrice = mdecBalcony;
                 break;
             case 2:
                 mPrice = mdecGeneral;
                 break;
             case 3:
                 mPrice = mdecBox;
                 break;
               case 4:
                  mPrice = mdecStall;
                  break;
            }
         if (discount)
         { mPrice -= mdecDiscount; }

           

            if (isChild)
            {
                mPrice -= mdecDiscountChild;
            }

            AmountDue = mPrice * quantity;

     }
    }
}
