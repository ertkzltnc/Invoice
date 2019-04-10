using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Invoice.Context
{
    public  class DbSingleTone
    {
        private static InvoiceContext db;
        public static InvoiceContext GetInstance()
        {
            if (db==null)
            {
                db = new InvoiceContext();
            }
            return db;
        }
        
    }
}
