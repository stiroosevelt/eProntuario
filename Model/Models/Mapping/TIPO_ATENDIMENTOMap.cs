using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class TIPO_ATENDIMENTOMap : EntityTypeConfiguration<TIPO_ATENDIMENTO>
    {
        public TIPO_ATENDIMENTOMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_TIPO_ATENDIMENTO);

            // Properties
            this.Property(t => t.NOM_TIPO_ATENDIMENTO)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.DES_TIPO_ATENDIMENTO)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.IND_ATIVO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("TIPO_ATENDIMENTO");
            this.Property(t => t.COD_TIPO_ATENDIMENTO).HasColumnName("COD_TIPO_ATENDIMENTO");
            this.Property(t => t.NOM_TIPO_ATENDIMENTO).HasColumnName("NOM_TIPO_ATENDIMENTO");
            this.Property(t => t.DES_TIPO_ATENDIMENTO).HasColumnName("DES_TIPO_ATENDIMENTO");
            this.Property(t => t.IND_ATIVO).HasColumnName("IND_ATIVO");
        }
    }
}
