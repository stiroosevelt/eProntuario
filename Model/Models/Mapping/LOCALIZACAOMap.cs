using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class LOCALIZACAOMap : EntityTypeConfiguration<LOCALIZACAO>
    {
        public LOCALIZACAOMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_LOCALIZACAO);

            // Properties
            this.Property(t => t.NUM_CEP_INICIO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.NUM_CEP_FIM)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("LOCALIZACAO");
            this.Property(t => t.COD_LOCALIZACAO).HasColumnName("COD_LOCALIZACAO");
            this.Property(t => t.COD_BAIRRO).HasColumnName("COD_BAIRRO");
            this.Property(t => t.COD_LOGRADOURO).HasColumnName("COD_LOGRADOURO");
            this.Property(t => t.NUM_CEP_INICIO).HasColumnName("NUM_CEP_INICIO");
            this.Property(t => t.NUM_CEP_FIM).HasColumnName("NUM_CEP_FIM");

            // Relationships
            this.HasRequired(t => t.BAIRRO)
                .WithMany(t => t.LOCALIZACAO)
                .HasForeignKey(d => d.COD_BAIRRO);
            this.HasRequired(t => t.LOGRADOURO)
                .WithMany(t => t.LOCALIZACAO)
                .HasForeignKey(d => d.COD_LOGRADOURO);

        }
    }
}
