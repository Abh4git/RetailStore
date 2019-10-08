///////////////////////////////////////////////////////////
//  DataModel.Products.cs
//  Implementation of the Class Products
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
	public partial class Product {



		~Product(){

		}

		public Product(){
       
		}

		public  string product_color{
			get;
			set;
		}

		public  string product_description{
			get;
			set;
		}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public  int product_id{
			get;
			set;
		}

		public  string product_name{
			get;
			set;
		}

		public  string product_other_details{
			get;
			set;
		}

		public  double product_price{
			get;
			set;
		}

		public  string product_size{
			get;
			set;
		}

		public  int product_type_code{
			get;
			set;
		}

		public  string return_merchant_authorization_nr{
			get;
			set;
		}

	}//end Products

}//end namespace Indus.Store.Services