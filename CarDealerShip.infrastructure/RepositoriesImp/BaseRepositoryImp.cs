


namespace CarDealerShip.infrastructure.RepositoriesImp
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        private readonly ApplicationDbContext _db;

        public BaseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IQueryable<T>> CreateAsync(T TT)
        {
            await _db.Set<T>().AddAsync(TT);
            _db.SaveChanges();
            return (IQueryable<T>)TT;
        }

        public async Task DeleteByIdAsync(int id)
        {
            var TT = await GetByIdAsync(id);
            _db.Set<T>().Remove((T)TT);
            _db.SaveChanges();

        }

        public async Task<IQueryable<IEnumerable<T>>> GetAllAsync()
        {
            return (IQueryable<IEnumerable<T>>)await _db.Set<T>().ToListAsync();
            
        }

        public async Task<IQueryable<T>> GetByIdAsync(int id)
        {
            var TT = await _db.Set<T>().FindAsync(id);

            return (IQueryable<T>)TT;

        }

        public async Task UpdateAsync(T TT)
        {

            _db.Set<T>().Update(TT);
            _db.SaveChanges();

        }
    }
}
