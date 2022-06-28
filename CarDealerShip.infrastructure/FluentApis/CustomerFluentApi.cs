

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealerShip.infrastructure.FluentApis
{
    public class CustomerFluentApi : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            
        }
    }
}
