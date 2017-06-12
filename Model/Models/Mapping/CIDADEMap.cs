using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class CIDADEMap : EntityTypeConfiguration<CIDADE>
    {
        public CIDADEMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_CIDADE);

            // Properties
            this.Property(t => t.COD_IBGE)
                .HasMaxLength(20);

            this.Property(t => t.NOM_CIDADE)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.NUM_CEP_PADRAO)
                .IsRequired()
                .HasMaxLength(9);

            this.Property(t => t.IND_ATIVO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("CIDADE");
            this.Property(t => t.COD_CIDADE).HasColumnName("COD_CIDADE");
            this.Property(t => t.COD_ESTADO).HasColumnName("COD_ESTADO");
            this.Property(t => t.COD_IBGE).HasColumnName("COD_IBGE");
            this.Property(t => t.NOM_CIDADE).HasColumnName("NOM_CIDADE");
            this.Property(t => t.NUM_CEP_PADRAO).HasColumnName("NUM_CEP_PADRAO");
            this.Property(t => t.IND_ATIVO).HasColumnName("IND_ATIVO");

            // Relationships
            this.HasRequired(t => t.ESTADO)
                .WithMany(t => t.CIDADE)
                .HasForeignKey(d => d.COD_ESTADO);

        }
    }
}
