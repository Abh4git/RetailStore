///////////////////////////////////////////////////////////
//  DataModel.Ref_Order_Status.cs
//  Implementation of the Class Ref_Order_Status
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
	public partial class Ref_Order_Status {



		~Ref_Order_Status(){

		}

		public Ref_Order_Status(){

		}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public  int order_status_code{
			get;
			set;
		}

		public  string order_status_description{
			get;
			set;
		}

		public  IList<Order> Orders{
			get;
			set;
		}

	}//end Ref_Order_Status

}//end namespace Indus.Store.Services