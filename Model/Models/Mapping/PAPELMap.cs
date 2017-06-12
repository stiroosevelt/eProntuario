using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class PAPELMap : EntityTypeConfiguration<PAPEL>
    {
        public PAPELMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_PAPEL);

            // Properties
            this.Property(t => t.NOM_PAPEL)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.NUM_CBO)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.IND_ATIVO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("PAPEL");
            this.Property(t => t.COD_PAPEL).HasColumnName("COD_PAPEL");
            this.Property(t => t.NOM_PAPEL).HasColumnName("NOM_PAPEL");
            this.Property(t => t.NUM_CBO).HasColumnName("NUM_CBO");
            this.Property(t => t.IND_ATIVO).HasColumnName("IND_ATIVO");
        }
    }
}
