using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst_Invoice.Entity
{
    public class InvoiceDetails
    {
        
        [Key,Column(Order = 0)]
        public int InvoiceID { get; set; }

        
        [Key,Column(Order = 1)]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public double VATAmount { get; set; }

        public double AmountWithVAT { get; set; }

        public string Description { get; set; }

        public virtual Product product { get; set; }

        public virtual InvoiceHeader invoiceHeader { get; set; }


    }
}
