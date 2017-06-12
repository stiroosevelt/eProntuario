using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class FUNCIONALIDADEMap : EntityTypeConfiguration<FUNCIONALIDADE>
    {
        public FUNCIONALIDADEMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_FUNCIONALIDADE);

            // Properties
            this.Property(t => t.NOM_FUNCIONALIDADE)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FUNCIONALIDADE");
            this.Property(t => t.COD_FUNCIONALIDADE).HasColumnName("COD_FUNCIONALIDADE");
            this.Property(t => t.NOM_FUNCIONALIDADE).HasColumnName("NOM_FUNCIONALIDADE");
        }
    }
}
