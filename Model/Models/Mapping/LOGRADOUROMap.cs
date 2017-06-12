using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class LOGRADOUROMap : EntityTypeConfiguration<LOGRADOURO>
    {
        public LOGRADOUROMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_LOGRADOURO);

            // Properties
            this.Property(t => t.NOM_LOGRADOURO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IND_ATIVO)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("LOGRADOURO");
            this.Property(t => t.COD_LOGRADOURO).HasColumnName("COD_LOGRADOURO");
            this.Property(t => t.COD_TIPO_LOGRADOURO).HasColumnName("COD_TIPO_LOGRADOURO");
            this.Property(t => t.NOM_LOGRADOURO).HasColumnName("NOM_LOGRADOURO");
            this.Property(t => t.IND_ATIVO).HasColumnName("IND_ATIVO");

            // Relationships
            this.HasRequired(t => t.TIPO_LOGRADOURO)
                .WithMany(t => t.LOGRADOURO)
                .HasForeignKey(d => d.COD_TIPO_LOGRADOURO);

        }
    }
}
