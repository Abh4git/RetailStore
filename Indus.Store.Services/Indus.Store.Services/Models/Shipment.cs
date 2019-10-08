///////////////////////////////////////////////////////////
//  DataModel.Shipments.cs
//  Implementation of the Class Shipments
//  Generated by Enterprise Architect
//  Created on:      05-Oct-2019 12:48:11
//  Original author: ABHILASH
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Indus.Store.Models
{
	public partial class Shipment {



		~Shipment(){

		}

		public Shipment(){

		}

		public  int invoice_number{
			get;
			set;
		}

        
		public int? order_id{
			get;
			set;
		}


		public  string other_shipment_details{
			get;
			set;
		}

		public  System.DateTime shipment_date{
			get;
			set;
		}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public  int shipment_id{
			get;
			set;
		}

		public  int shipment_tracking_number{
			get;
			set;
		}

        //Navigation Properties
        public Invoice Invoice
        {
            get;
            set;
        }


        [ForeignKey("order_id")]
        public virtual Order Order
        {
            get;
            set;
        }

        public ICollection<Shipment_Item> Shipment_Items
        {
            get;
            set;
        }

     

    }//end Shipments

}//end namespace Indus.Store.Services