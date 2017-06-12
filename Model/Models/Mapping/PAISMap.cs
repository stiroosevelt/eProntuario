using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class PAISMap : EntityTypeConfiguration<PAIS>
    {
        public PAISMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_PAIS);

            // Properties
            this.Property(t => t.NOM_PAIS)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DES_SIGLA_PAIS)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.IND_ATIVO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("PAIS");
            this.Property(t => t.COD_PAIS).HasColumnName("COD_PAIS");
            this.Property(t => t.NOM_PAIS).HasColumnName("NOM_PAIS");
            this.Property(t => t.DES_SIGLA_PAIS).HasColumnName("DES_SIGLA_PAIS");
            this.Property(t => t.IND_ATIVO).HasColumnName("IND_ATIVO");
        }
    }
}
