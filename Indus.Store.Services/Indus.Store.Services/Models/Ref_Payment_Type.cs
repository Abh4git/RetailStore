///////////////////////////////////////////////////////////
//  DataModel.Ref_Payment_Types.cs
//  Implementation of the Class Ref_Payment_Types
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
	public partial class Ref_Payment_Type {



		~Ref_Payment_Type(){

		}

		public Ref_Payment_Type(){

		}


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int payment_type_code{
			get;
			set;
		}

		public  string payment_type_description{
			get;
			set;
		}

	}//end Ref_Payment_Types

}//end namespace Indus.Store.Services