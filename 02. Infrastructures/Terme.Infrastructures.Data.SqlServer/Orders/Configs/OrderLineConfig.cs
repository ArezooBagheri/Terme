using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Terme.Core.Domain.Orders.Entities;

namespace Terme.Infrastructures.Data.SqlServer.Orders.Configs
{
    public class OrderLineConfig : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
        }
    }
}
