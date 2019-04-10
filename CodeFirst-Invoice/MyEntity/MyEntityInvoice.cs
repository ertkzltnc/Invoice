using System;

namespace CodeFirst_Invoice
{
    internal class MyEntityInvoice
    {
        public int InvoiceNo { get; set; }
        public int CustomerNo { get; internal set; }
        public string CustomerNAme { get; set; }
        public string ProdıuıctName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double VatAmount { get; set; }
        public double AmountWithVat { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Descirtion { get; set; }
    
    }
}