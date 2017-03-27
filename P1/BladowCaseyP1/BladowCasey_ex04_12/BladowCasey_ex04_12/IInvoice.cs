using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex04_12
{
    public interface IInvoice
    {
        decimal GetInvoiceAmount();
        string PartDescription { get; set; }
        string PartNumber { get; set; }
        decimal PricePerItem { get; set; }
        int Quantity { get; set; }
    }
}
