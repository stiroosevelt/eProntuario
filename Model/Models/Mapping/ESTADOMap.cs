using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class ESTADOMap : EntityTypeConfiguration<ESTADO>
    {
        public ESTADOMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_ESTADO);

            // Properties
            this.Property(t => t.NOM_ESTADO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DES_SIGLA_ESTADO)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.IND_ATIVO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ESTADO");
            this.Property(t => t.COD_ESTADO).HasColumnName("COD_ESTADO");
            this.Property(t => t.COD_PAIS).HasColumnName("COD_PAIS");
            this.Property(t => t.NOM_ESTADO).HasColumnName("NOM_ESTADO");
            this.Property(t => t.DES_SIGLA_ESTADO).HasColumnName("DES_SIGLA_ESTADO");
            this.Property(t => t.IND_ATIVO).HasColumnName("IND_ATIVO");

            // Relationships
            this.HasRequired(t => t.PAIS)
                .WithMany(t => t.ESTADO)
                .HasForeignKey(d => d.COD_PAIS);

        }
    }
}
