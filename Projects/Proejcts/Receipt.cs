﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    class Receipt
    {
        //private variables 
        private int receiptNumber;
        private string dateOfPurchase;
        private int customerNumber;
        private string customerFirstName;
        private string customerLastName;
        private string customerAddress;
        private string customerPhoneNumber;
        private int itemNumber;
        private string itemDescription;
        private decimal unitPrice;
        private int quantityPurchased;

        //constructor
        public Receipt(int receiptNum, string purchaseDate, int customerNum, string cFirstName,
            string cLastName, string cAddress, string cPhoneNumber, int itemNum,
            string itemDescr, decimal Price, int quantity)
        {
            receiptNumber = receiptNum;
            dateOfPurchase = purchaseDate;
            customerNumber = customerNum;
            customerFirstName = cFirstName;
            customerLastName = cLastName;
            customerAddress = cAddress;
            customerPhoneNumber = cPhoneNumber;
            itemNumber = itemNum;
            itemDescription = itemDescr;
            unitPrice = Price;
            quantityPurchased = quantity;
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
            }
        }

        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerPhoneNumber { get; set; }

        public int ItemNumber
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
            }
        }

        public string ItemDescription { get; set; }

        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                //check that unit price is greater than 0 and less than 9999
                if (value > 0 && value < 9999)
                {
                    unitPrice = value;
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

        



    

