using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Invoice();
            invoice.AddInvoice();
            invoice.DeleteInvoice();
        }
    }
}
