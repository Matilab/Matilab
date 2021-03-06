using lab.Domain.Entities.Bloco.b0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config.Bloco0
{
    class Reg0145EFDCConfiguration : IEntityTypeConfiguration<Reg0145EFDC>
    {
        public void Configure(EntityTypeBuilder<Reg0145EFDC> builder)
        {
            builder.HasKey(_0145 => _0145.Id);
            builder.Property(_0145 => _0145.Reg).HasMaxLength(4).HasDefaultValue("0145").IsRequired();
            builder.Property(_0145 => _0145.CodIncTrib).HasMaxLength(1).IsRequired();
            builder.Property(_0145 => _0145.VlRecTot).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(_0145 => _0145.VlRecAtiv).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(_0145 => _0145.VlRecDemaisAtiv).HasColumnType("decimal(18, 2)");
            builder.Property(_0145 => _0145.InfoCompl).HasMaxLength(255);
        }
    }
}
