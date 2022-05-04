using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.Domain.Orders;

namespace Sample.Infrastructure.Domain.Orders;

public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(g => g.Id);
        builder.Property(g => g.CreationTime).IsRequired();
    }
}
