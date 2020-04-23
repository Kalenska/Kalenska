using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class Receipt
    {
        //public variables 
        public int receiptNumber;
        public string dateOfPurchase;
        public int customerNumber;
        public string customerFirstName;
        public string customerLastName;
        public string customerAddress;
        public string customerPhoneNumber;
        public int itemNumber;
        public string itemDescription;
        public decimal unitPrice;
        public int quantityPurchased;

        //constructor
        public Receipt(int receiptNum, string purchaseDate, int customerNum, string cFirstName,
            string cLastName, string cAddress, string cPhoneNumber, int itemNum,
            string itemDescr, decimal Price, int quantity)
        {
            ReceiptNumber = receiptNum;
            DateOfPurchase = purchaseDate;
            CustomerNumber = customerNum;
            CustomerFirstName = cFirstName;
            CustomerLastName = cLastName;
            CustomerAddress = cAddress;
            CustomerPhoneNumber = cPhoneNumber;
            ItemNumbеr = itemNum;
            ItemDescription = itemDescr;
            UnitPrice = Price;
            QuantityPurchased = quantity;
        }

        //properties 
        public int ReceiptNumber
        {
            get
            {
                return receiptNumber;
            }
            set
            {
                //check that receopt number is greater than 0 
                if (value > 0)
                {
                    receiptNumber = value;
                }
                else
                {
                    throw new InvalidOperationException("Value cannot be less or equal to 0");
                }
            }
        }

        public string DateOfPurchase
        {
            get
            {
                return dateOfPurchase;
            }
            set
            {
                 dateOfPurchase = value;
            }
        }

        public int CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                //check that customer number is greater than 0 
                if (value > 0)
                {
                    customerNumber = value;
                }
                else
                {
                    throw new InvalidOperationException("Value cannot be less than 0 and greater than 9999");
                }
            }
        }

        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerPhoneNumber { get; set; }

        public int ItemNumbеr
        {
            get
            {
                return itemNumber;
            }
            set
            {
                //check that item number is greater than 0 and less than 9999
                if (value > 0 && value < 9999)
                {
                    itemNumber = value;
                }
                else
                {
                    throw new InvalidOperationException("Value cannot be less than 0 and greater than 9999");
                }
            }
        }

        public string ItemDescription { get; set; }
   

        public decimal UnitPrice
        {
            get
            {
                return UnitPrice;
            }
            set
            {
                //check that unit price is greater than 0 and less than 9999
                if (value > 0 && value < 9999)
                {
                    UnitPrice = value;
                }
            }
        }

        public int QuantityPurchased
        {
            get
            {
                return quantityPurchased;
            }
            set
            {
                //check that quantity purchased is greater than 0 and less than 9999
                if (value > 0)
                {
                    quantityPurchased = value;
                }
            else
            {
                throw new InvalidOperationException("Value cannot be less than 0");
            }
        }
    
        

        //Methods

        public decimal CalculateTotalCost()
        {
            return quantityPurchased * unitPrice;
        }

        public override string ToString()
        {
            return "Customer: " + customerFirstName + " " + customerLastName + 
                "\nPhone: " + customerPhoneNumber + 
                "\nTotal Purchases: " + CalculateTotalCost().ToString("C");
        }
    }
}

        



    

