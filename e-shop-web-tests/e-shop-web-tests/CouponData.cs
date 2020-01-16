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
        private string discount_amount = "";
        private string valid_date = "";
        private string number_coupons = "";

        public CouponData(string name)
        {
            this.name = name;
           
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

        public string Number_coupons
        {
            get
            {
                return number_coupons;
            }
            set
            {
                number_coupons = value;
            }
        }


    }
}
