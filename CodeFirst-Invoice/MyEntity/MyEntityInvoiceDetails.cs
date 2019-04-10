namespace CodeFirst_Invoice
{
    internal class MyEntityInvoiceDetails
    {
        public int InvoiceNo { get; set; }
        public int ProductNo { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double VatAmount { get; set; }
        public double AmountWithVat { get; set; }
        public string Descirtion { get; set; }
    }
}