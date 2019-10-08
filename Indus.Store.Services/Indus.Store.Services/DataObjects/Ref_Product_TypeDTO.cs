using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indus.Store.Services.DataObjects
{
    public class Ref_Product_TypeDTO
    {

        public int parent_product_type_code
        {
            get;
            set;
        }

        public int product_id
        {
            get;
            set;
        }

        public int product_type_code
        {
            get;
            set;
        }

        public string product_type_description
        {
            get;
            set;
        }

    }
}
