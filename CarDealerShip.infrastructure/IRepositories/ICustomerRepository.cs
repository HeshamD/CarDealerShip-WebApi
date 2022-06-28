using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip.infrastructure.IRepositories
{
    public interface ICustomerRepository
    {
        //function to get customer based on thier phone number
        public Task<IQueryable<CustomerEntity>> GetCustomerByNumber(string customerNumber);
    }
}
