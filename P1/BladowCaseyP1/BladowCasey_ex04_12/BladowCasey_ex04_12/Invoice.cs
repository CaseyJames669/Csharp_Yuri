using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex04_12
{
    public class Invoice : IInvoice
    {
        public Invoice(string part, string description, int count, decimal price)
        {
            PartNumber = part;
            PartDescription = description;
            Quantity = count;
            PricePerItem = price;
        }

        public decimal GetInvoiceAmount()
        {
            //throw new NotImplementedException();
            return Quantity * PricePerItem;
        }
        /*
        public string PartDescription
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        */
        public string PartDescription { get; set; }
        public string PartNumber { get; set; }
        /*
        public string PartNumber
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        */
        private decimal pricePerItem;
        public decimal PricePerItem
        {
            get
            {
                //throw new NotImplementedException();
                return pricePerItem;
            }
            set
            {
                //throw new NotImplementedException();
                if (value >= 0)
                    pricePerItem = value;
            }
        }
        private int quantity;
        public int Quantity
        {
            get
            {
                //throw new NotImplementedException();
                return quantity;
            }
            set
            {
                //throw new NotImplementedException();
                if (value >= 0)
                    quantity = value;
            }
        }
    }
}
