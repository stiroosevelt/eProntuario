using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class TIPO_LOGRADOUROMap : EntityTypeConfiguration<TIPO_LOGRADOURO>
    {
        public TIPO_LOGRADOUROMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_TIPO_LOGRADOURO);

            // Properties
            this.Property(t => t.NOM_TIPO_LOGRADOURO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DES_SIGLA_LOGRADOURO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.IND_ATIVO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("TIPO_LOGRADOURO");
            this.Property(t => t.COD_TIPO_LOGRADOURO).HasColumnName("COD_TIPO_LOGRADOURO");
            this.Property(t => t.NOM_TIPO_LOGRADOURO).HasColumnName("NOM_TIPO_LOGRADOURO");
            this.Property(t => t.DES_SIGLA_LOGRADOURO).HasColumnName("DES_SIGLA_LOGRADOURO");
            this.Property(t => t.IND_ATIVO).HasColumnName("IND_ATIVO");
        }
    }
}
