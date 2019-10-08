using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indus.Store.Services.DataObjects
{
    public class InvoiceDTO
    {
        public int invoice_number
        {
            get;
            set;
        }

        public System.DateTime invoice_date
        {
            get;
            set;
        }

        public string invoice_details
        {
            get;
            set;
        }



        public int invoice_status_code
        {
            get;
            set;
        }

        public int order_id
        {
            get;
            set;
        }

        //Navigation Properties
        public OrderDTO Order
        {
            get;
            set;
        }

        public Ref_Invoice_StatusDTO Ref_Invoice_Status
        {
            get;
            set;
        }

    }
}
