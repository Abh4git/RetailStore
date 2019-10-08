///////////////////////////////////////////////////////////
//  DataModel.Shipment_Items.cs
//  Implementation of the Class Shipment_Items
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
	public partial class Shipment_Item {



		~Shipment_Item(){

		}

		public Shipment_Item(){

		}
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int shipment_Item_id
        {
            get;
            set;
        }
       
		public  int order_Item_id{
			get;
			set;
		}

              
        //Navigation Properties
        public Order_Item Order_Item
        {
            get;
            set;
        }
        public  Shipment Shipment{
			get;
			set;
		}

	}//end Shipment_Items

}//end namespace Indus.Store.Services