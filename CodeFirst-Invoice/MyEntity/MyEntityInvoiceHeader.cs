using System;

namespace CodeFirst_Invoice
{
    internal class MyEntityInvoiceHeader
    {
        public int invoiceNo { get; set; }

        public string Customer { get; internal set; }
        public decimal? Total { get; internal set; }
        public DateTime InvoiceDate { get; internal set; }
        public DateTime PaymentDate { get; internal set; }
        public string DeliveryNote { get; internal set; }
    }
}