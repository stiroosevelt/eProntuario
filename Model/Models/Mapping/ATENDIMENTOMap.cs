using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class ATENDIMENTOMap : EntityTypeConfiguration<ATENDIMENTO>
    {
        public ATENDIMENTOMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_ATENDIMENTO);

            // Properties
            // Table & Column Mappings
            this.ToTable("ATENDIMENTO");
            this.Property(t => t.COD_ATENDIMENTO).HasColumnName("COD_ATENDIMENTO");
            this.Property(t => t.COD_ESTABELECIMENTO).HasColumnName("COD_ESTABELECIMENTO");
            this.Property(t => t.COD_TIPO_ATENDIMENTO).HasColumnName("COD_TIPO_ATENDIMENTO");
            this.Property(t => t.COD_INDIVIDUO).HasColumnName("COD_INDIVIDUO");
            this.Property(t => t.DAT_ATENDIMENTO).HasColumnName("DAT_ATENDIMENTO");
            this.Property(t => t.COD_VINCULO_PROFISSIONAL).HasColumnName("COD_VINCULO_PROFISSIONAL");

            // Relationships
            this.HasRequired(t => t.ESTABELECIMENTO)
                .WithMany(t => t.ATENDIMENTO)
                .HasForeignKey(d => d.COD_ESTABELECIMENTO);
            this.HasRequired(t => t.INDIVIDUO)
                .WithMany(t => t.ATENDIMENTO)
                .HasForeignKey(d => d.COD_INDIVIDUO);
            this.HasRequired(t => t.TIPO_ATENDIMENTO)
                .WithMany(t => t.ATENDIMENTO)
                .HasForeignKey(d => d.COD_TIPO_ATENDIMENTO);
            this.HasOptional(t => t.VINCULO_PROFISSIONAL)
                .WithMany(t => t.ATENDIMENTOes)
                .HasForeignKey(d => d.COD_VINCULO_PROFISSIONAL);

        }
    }
}
