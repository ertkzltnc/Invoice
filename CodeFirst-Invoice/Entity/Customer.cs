using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Invoice.Entity
{
    public class Customer
    {
        public Customer()
        {
            this.invoiceHeader = new HashSet<InvoiceHeader>();
        }

        public int CustomerID { get; set; }
        

        public string  CompanyName { get; set; }

        public int CountyID { get; set; }

        public string Address { get; set; }

        public virtual County county { get; set; }

        public virtual ICollection<InvoiceHeader> invoiceHeader { get; set; }

    }
}
