


namespace CarDealerShip.infrastructure.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        public Task<IQueryable<T>> CreateAsync(T TT);
        public Task<IQueryable<T>> GetByIdAsync(int id);
        public Task<IQueryable<IEnumerable<T>>> GetAllAsync();
        public Task DeleteByIdAsync(int id);
        public Task UpdateAsync(T TT);

    }
}
