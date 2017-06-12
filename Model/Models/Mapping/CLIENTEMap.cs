using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class CLIENTEMap : EntityTypeConfiguration<CLIENTE>
    {
        public CLIENTEMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_CLIENTE);

            // Properties
            this.Property(t => t.NOM_CLIENTE)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.NUM_CONTRATO)
                .HasMaxLength(100);

            this.Property(t => t.NOM_RESPONSAVEL)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.DES_EMAIL)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("CLIENTE");
            this.Property(t => t.COD_CLIENTE).HasColumnName("COD_CLIENTE");
            this.Property(t => t.NOM_CLIENTE).HasColumnName("NOM_CLIENTE");
            this.Property(t => t.NUM_CONTRATO).HasColumnName("NUM_CONTRATO");
            this.Property(t => t.NOM_RESPONSAVEL).HasColumnName("NOM_RESPONSAVEL");
            this.Property(t => t.DES_EMAIL).HasColumnName("DES_EMAIL");
            this.Property(t => t.COD_CIDADE).HasColumnName("COD_CIDADE");
            this.Property(t => t.COD_BAIRRO).HasColumnName("COD_BAIRRO");
            this.Property(t => t.COD_LOGRADOURO).HasColumnName("COD_LOGRADOURO");

            // Relationships
            this.HasOptional(t => t.BAIRRO)
                .WithMany(t => t.CLIENTE)
                .HasForeignKey(d => d.COD_BAIRRO);
            this.HasRequired(t => t.CIDADE)
                .WithMany(t => t.CLIENTE)
                .HasForeignKey(d => d.COD_CIDADE);
            this.HasOptional(t => t.LOGRADOURO)
                .WithMany(t => t.CLIENTE)
                .HasForeignKey(d => d.COD_LOGRADOURO);

        }
    }
}
