using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEshopTests
{
    class CouponData
    {
        private string name;
        private string discount_amount;
        private string valid_date;

        public CouponData(string name, string discount_amount)
        {
            this.name = name;
            this.discount_amount = discount_amount;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        

            public string Discount_amount
        {
            get
            {
                return discount_amount;
            }
            set
            {
                discount_amount = value;
            }
        }

        public string Valid_date
        {
            get
            {
                return valid_date;
            }
            set
            {
                valid_date = value;
            }
        }


    }
}
