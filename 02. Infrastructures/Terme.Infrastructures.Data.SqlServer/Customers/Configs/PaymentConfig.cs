using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Terme.Core.Domain.Customers.Entities;

namespace Terme.Infrastructures.Data.SqlServer.Customers.Configs
{
    public class PaymentConfig : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {

        }
    }
}
