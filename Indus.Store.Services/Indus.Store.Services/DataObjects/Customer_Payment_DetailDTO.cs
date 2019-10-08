using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indus.Store.Services.DataObjects
{
    public class Customer_Payment_DetailDTO
    {
        public string credit_card_detail
        {
            get;
            set;
        }

        public int customer_id
        {
            get;
            set;
        }

        public int customer_payment_id
        {
            get;
            set;
        }

        public int customer_payment_type_code
        {
            get;
            set;
        }
        public string payment_details
        {
            get;
            set;
        }

        //Navigation Properties
        public CustomerDTO Customer
        {
            get;
            set;
        }

        public Ref_Payment_TypeDTO Ref_Payment_Type
        {
            get;
            set;
        }

    }
}
