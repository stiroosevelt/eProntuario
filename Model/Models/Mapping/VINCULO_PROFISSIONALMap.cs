using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class VINCULO_PROFISSIONALMap : EntityTypeConfiguration<VINCULO_PROFISSIONAL>
    {
        public VINCULO_PROFISSIONALMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_VINCULO_PROFISSIONAL);

            // Properties
            // Table & Column Mappings
            this.ToTable("VINCULO_PROFISSIONAL");
            this.Property(t => t.COD_VINCULO_PROFISSIONAL).HasColumnName("COD_VINCULO_PROFISSIONAL");
            this.Property(t => t.COD_PROFISSIONAL).HasColumnName("COD_PROFISSIONAL");
            this.Property(t => t.COD_ESTABELECIMENTO).HasColumnName("COD_ESTABELECIMENTO");
            this.Property(t => t.COD_PAPEL).HasColumnName("COD_PAPEL");

            // Relationships
            this.HasOptional(t => t.ESTABELECIMENTO)
                .WithMany(t => t.VINCULO_PROFISSIONAL)
                .HasForeignKey(d => d.COD_ESTABELECIMENTO);
            this.HasOptional(t => t.PAPEL)
                .WithMany(t => t.VINCULO_PROFISSIONAL)
                .HasForeignKey(d => d.COD_PAPEL);
            this.HasOptional(t => t.PROFISSIONAL)
                .WithMany(t => t.VINCULO_PROFISSIONAL)
                .HasForeignKey(d => d.COD_PROFISSIONAL);

        }
    }
}
