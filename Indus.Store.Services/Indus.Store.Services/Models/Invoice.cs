///////////////////////////////////////////////////////////
//  DataModel.Invoices.cs
//  Implementation of the Class Invoices
//  Generated by Enterprise Architect
//  Created on:      05-Oct-2019 12:48:11
//  Original author: ABHILASH
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;


using Indus.Store.Services;
using System.ComponentModel.DataAnnotations.Schema;

namespace Indus.Store.Models
{
	public partial class Invoice {



		~Invoice(){

		}

		public Invoice(){

		}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int invoice_number
        {
            get;
            set;
        }

        public  System.DateTime invoice_date{
			get;
			set;
		}

		public  string invoice_details{
			get;
			set;
		}



		public  int invoice_status_code{
			get;
			set;
		}

		public  int order_id{
			get;
			set;
		}

        //Navigation Properties
		public Order Order{
			get;
			set;
		}

		public  Ref_Invoice_Status Ref_Invoice_Status{
			get;
			set;
		}


	}//end Invoices

}//end namespace Indus.Store.Services