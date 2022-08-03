using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ProductoConfig : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Productos");
            builder.HasKey(p => p.Codigo);
            builder.Property(p => p.Descripcion)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(p => p.Estado)
                .HasMaxLength(20)
                .IsRequired();
            builder.Property(p => p.FechaFabricacion)
                .IsRequired();
            builder.Property(p => p.FechaValidez)
                .IsRequired();
            builder.Property(p => p.CodigoProveedor)
                .IsRequired();
            builder.Property(p => p.DescripcionProveedor)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(p => p.TelefonoProveedor)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
