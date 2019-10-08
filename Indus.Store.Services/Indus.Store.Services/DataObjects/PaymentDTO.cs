using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indus.Store.Services.DataObjects
{
    public class PaymentDTO
    {
        public int invoice_number
        {
            get;
            set;
        }

        public InvoiceDTO Invoice
        {
            get;
            set;
        }

        public Decimal payment_amount
        {
            get;
            set;
        }

        public System.DateTime payment_date
        {
            get;
            set;
        }

        public int payment_id
        {
            get;
            set;
        }

    }
}
