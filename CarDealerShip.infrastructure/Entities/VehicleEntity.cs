using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip.infrastructure.Entities
{
    public class VehicleEntity
    {
        public int VehicleId { get; set; }
        public string? Vehicle_Year { get; set; }
        public string? Vehicle_Make { get; set; }
        public string? Vehicle_Model { get; set; }
        public string? Vehicle_VinNumber { get; set; }
        public string? Vehicle_Mileage { get; set; }
        public string? Vehicle_Type { get; set; }
        public string? Vehicle_Exterior_Color { get; set; }
        public string? Vehicle_Price { get; set; }
        public string? Vehicle_Trim { get; set; }
        public string? Vehicle_FuelType { get; set; }
        public string? Vehicle_Description { get; set; }
        public string? Vehicle_Doors { get; set; }
        public string? Vehicle_Cylinders { get; set; }

    }
}
