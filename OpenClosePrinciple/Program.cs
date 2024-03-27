using System;

namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Invoice.GetInvoiceDiscount(223, Invoice.InvoiceType.FinalInvoice);
            Console.WriteLine("FinalInvoice: {0}",x.ToString());
            double y = Invoice.GetInvoiceDiscount(323, Invoice.InvoiceType.ProposedInvoice);
            Console.WriteLine("ProposedInvoice: {0}", y.ToString());
        }
    }
}
