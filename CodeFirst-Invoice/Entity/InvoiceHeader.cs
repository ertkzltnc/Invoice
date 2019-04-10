using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Invoice.Entity
{
    public class InvoiceHeader
    {

        public InvoiceHeader()
        {
            this.invoiceDetails = new HashSet<InvoiceDetails>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceID { get; set; }


        public int CustomerID { get; set; }

        public DateTime InvoiceDate { get; set; }

        public string DeliveryNote { get; set; }

        public DateTime PaymentDate{ get; set; }
        [DisplayFormat(NullDisplayText ="0.18")]
        public decimal? TotalAmount { get; set; }

        public virtual ICollection<InvoiceDetails> invoiceDetails { get; set; }

        public virtual Customer customer { get; set; }
    }
}
