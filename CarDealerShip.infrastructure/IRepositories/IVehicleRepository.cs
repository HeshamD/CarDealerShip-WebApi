using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip.infrastructure.IRepositories
{
    interface IVehicleRepository
    {
        public Task<IQueryable<VehicleEntity>> GetVehicleVinNumber(string vinNumber);

    }
}
