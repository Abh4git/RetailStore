using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indus.Store.Services.DataObjects
{
    public class CustomerDTO
    {
        public int customer_id
        {
            get;
            set;
        }

        public string address_line1
        {
            get;
            set;
        }

        public string address_line2
        {
            get;
            set;
        }

        public string address_line3
        {
            get;
            set;
        }

        public string address_line4
        {
            get;
            set;
        }

        public string country
        {
            get;
            set;
        }

        public string county_or_province
        {
            get;
            set;
        }



        public string email_address
        {
            get;
            set;
        }

        public string first_name
        {
            get;
            set;
        }

        public int gender
        {
            get;
            set;
        }

        public string last_name
        {
            get;
            set;
        }

        public string login_name
        {
            get;
            set;
        }

        public string login_password
        {
            get;
            set;
        }

        public string middle_name
        {
            get;
            set;
        }


        public string organization_name
        {
            get;
            set;
        }

        public Byte organization_or_person
        {
            get;
            set;
        }

        public string phone_number
        {
            get;
            set;
        }

        public string town_city
        {
            get;
            set;
        }

        //Navigation properties
        public Customer_Payment_DetailDTO Customer_Payment_Details
        {
            get;
            set;
        }

        public ICollection<OrderDTO> Orders
        {
            get;
            set;
        }

    }
}
