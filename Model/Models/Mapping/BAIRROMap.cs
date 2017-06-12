using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class BAIRROMap : EntityTypeConfiguration<BAIRRO>
    {
        public BAIRROMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_BAIRRO);

            // Properties
            this.Property(t => t.NOM_BAIRRO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IND_ATIVO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("BAIRRO");
            this.Property(t => t.COD_BAIRRO).HasColumnName("COD_BAIRRO");
            this.Property(t => t.COD_CIDADE).HasColumnName("COD_CIDADE");
            this.Property(t => t.NOM_BAIRRO).HasColumnName("NOM_BAIRRO");
            this.Property(t => t.IND_ATIVO).HasColumnName("IND_ATIVO");

            // Relationships
            this.HasRequired(t => t.CIDADE)
                .WithMany(t => t.BAIRRO)
                .HasForeignKey(d => d.COD_CIDADE);

        }
    }
}
