using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class ESTABELECIMENTOMap : EntityTypeConfiguration<ESTABELECIMENTO>
    {
        public ESTABELECIMENTOMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_ESTABELECIMENTO);

            // Properties
            this.Property(t => t.NOM_ESTABELECIMENTO)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ESTABELECIMENTO");
            this.Property(t => t.COD_ESTABELECIMENTO).HasColumnName("COD_ESTABELECIMENTO");
            this.Property(t => t.COD_CLIENTE).HasColumnName("COD_CLIENTE");
            this.Property(t => t.NOM_ESTABELECIMENTO).HasColumnName("NOM_ESTABELECIMENTO");

            // Relationships
            this.HasRequired(t => t.CLIENTE)
                .WithMany(t => t.ESTABELECIMENTO)
                .HasForeignKey(d => d.COD_CLIENTE);

        }
    }
}
