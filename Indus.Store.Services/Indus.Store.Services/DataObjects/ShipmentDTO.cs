using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indus.Store.Services.DataObjects
{
    public class ShipmentDTO
    {
        public int invoice_number
        {
            get;
            set;
        }


        public int? order_id
        {
            get;
            set;
        }


        public string other_shipment_details
        {
            get;
            set;
        }

        public System.DateTime shipment_date
        {
            get;
            set;
        }

        public int shipment_id
        {
            get;
            set;
        }

        public int shipment_tracking_number
        {
            get;
            set;
        }

        //Navigation Properties
        public InvoiceDTO Invoice
        {
            get;
            set;
        }


        public virtual OrderDTO Order
        {
            get;
            set;
        }

        public ICollection<Shipment_ItemDTO> Shipment_Items
        {
            get;
            set;
        }


    }
}
