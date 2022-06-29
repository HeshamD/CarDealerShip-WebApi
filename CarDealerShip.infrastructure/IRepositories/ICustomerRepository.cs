
namespace CarDealerShip.infrastructure.IRepositories
{
    public interface ICustomerRepository
    {
        public Task<IQueryable<CustomerEntity>> GetCustomerByNumber(string customerNumber);
        public Task<IQueryable<CustomerEntity>> GetCustomerByEmail(string customerEmail);
    }
}
