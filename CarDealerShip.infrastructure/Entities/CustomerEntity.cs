using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip.infrastructure.Entities
{
    public class CustomerEntity
    {
        public string Customer_Id { get; set; }
        public string Customer_FirstName { get; set;}
        public string Customer_LastName { get; set; }
        public string Customer_Email { get; set;}
        public string Customer_FullName { get; set;}
        public string Customer_Phone { get; set; }
        public string getCustomerFullName()
        {
            this.Customer_FullName = this.Customer_FirstName + " " + this.Customer_LastName;
            return this.Customer_FullName;
        }

    }
}
