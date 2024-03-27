using System;

namespace OpenClosePrincipleSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice FinalInvoice = new FinalInvoice();
            Invoice ProposedInvoice = new ProposedInvoice();
            Invoice ReccuringInvoice = new RecurringInvoice();
            double FinalInvoiceAmount = FinalInvoice.GetInvoiceDiscount(10000);
            double ProposedInvoiceAmount = ProposedInvoice.GetInvoiceDiscount(10000);
            double ReccuringInvoiceAmount = ReccuringInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine("Starting InvoiceAmount: {0}", 10000.ToString());
            Console.WriteLine("Final Invoice Amount: {0}", FinalInvoiceAmount.ToString());
            Console.WriteLine("Proposed Invoice Amount: {0}", ProposedInvoiceAmount.ToString());
            Console.WriteLine("Reccuring Invoice Amount: {0}", ReccuringInvoiceAmount.ToString());
            Console.ReadKey();
        }
    }
}
