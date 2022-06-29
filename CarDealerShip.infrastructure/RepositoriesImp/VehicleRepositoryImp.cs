using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip.infrastructure.RepositoriesImp
{
    public class VehicleRepositoryImp : IVehicleRepository
    {

        protected readonly ApplicationDbContext _db;

        public VehicleRepositoryImp(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IQueryable<VehicleEntity>> GetVehicleVinNumber(string vinNumber)
        {
            var Vehicle = await _db.Vehicles.SingleAsync(v => v.Vehicle_VinNumber == vinNumber);

            return (IQueryable<VehicleEntity>)Vehicle;
        }
    }
}
