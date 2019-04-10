using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Invoice.Entity
{
    public class Product
    {

        public Product()
        {
            this.invoiceDetails = new HashSet<InvoiceDetails>();
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductCode { get; set; }
        public int UnitID {get; set; }
        public double UnitPrice { get; set; }

        public virtual Unit unit { get; set; }

        public virtual ICollection<InvoiceDetails> invoiceDetails{ get; set; }

    }
}
