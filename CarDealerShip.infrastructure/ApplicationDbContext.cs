

namespace CarDealerShip.infrastructure
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new CustomerEntity());
            modelBuilder.ApplyConfiguration(new VehicleEntity());

        }


        // creating tables 

        public DbSet<CustomerEntity> Customers { get; set; } 
        public DbSet<VehicleEntity> Vehicles { get; set; }

    }
}
