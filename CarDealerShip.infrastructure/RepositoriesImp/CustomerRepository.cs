using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip.infrastructure.RepositoriesImp
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _db ;
        public async Task<IQueryable<CustomerEntity>> GetCustomerByNumber(string customerNumber)
        {
            var Customer = await _db.Customers.SingleAsync(c => c.Customer_Phone == customerNumber);

            return (IQueryable<CustomerEntity>)Customer;
        }
    }
}
