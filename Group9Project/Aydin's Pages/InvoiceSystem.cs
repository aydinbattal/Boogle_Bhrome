using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group9Project.Aydin_s_Pages
{
    class InvoiceSystem
    {
        public int InvoiceNumber { get; set; }
        public DateTime Date { get; set; }

        public double DepositAmount { get; set; }
        public double WithDrawAmount { get; set; }
        public double TempBalance { get; set; }

        public double TempOverdraftAmount { get; set; }

        public List<InvoiceSystem> InvoiceList = new List<InvoiceSystem>();
        public void AddInvoice(double depositAmt, double withdrawAmt, double balance, double overdraftAmt)
        {
            int id = InvoiceList.Count + 1;
            InvoiceList.Add(new InvoiceSystem
            {
                InvoiceNumber = id,
                Date = DateTime.Now,
                DepositAmount = depositAmt,
                WithDrawAmount = withdrawAmt,
                TempBalance = balance,
                TempOverdraftAmount = overdraftAmt
            });
        }



    }
}
