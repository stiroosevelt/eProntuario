using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class ACESSOMap : EntityTypeConfiguration<ACESSO>
    {
        public ACESSOMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_ACESSO);

            // Properties
            this.Property(t => t.IND_CONSULTAR)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IND_INSERIR)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IND_EXCLUIR)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IND_ALTERAR)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IND_IMPRIMIR)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ACESSO");
            this.Property(t => t.COD_ACESSO).HasColumnName("COD_ACESSO");
            this.Property(t => t.COD_PAPEL).HasColumnName("COD_PAPEL");
            this.Property(t => t.COD_FUNCIONALIDADE).HasColumnName("COD_FUNCIONALIDADE");
            this.Property(t => t.IND_CONSULTAR).HasColumnName("IND_CONSULTAR");
            this.Property(t => t.IND_INSERIR).HasColumnName("IND_INSERIR");
            this.Property(t => t.IND_EXCLUIR).HasColumnName("IND_EXCLUIR");
            this.Property(t => t.IND_ALTERAR).HasColumnName("IND_ALTERAR");
            this.Property(t => t.IND_IMPRIMIR).HasColumnName("IND_IMPRIMIR");

            // Relationships
            this.HasRequired(t => t.FUNCIONALIDADE)
                .WithMany(t => t.ACESSO)
                .HasForeignKey(d => d.COD_FUNCIONALIDADE);
            this.HasRequired(t => t.PAPEL)
                .WithMany(t => t.ACESSO)
                .HasForeignKey(d => d.COD_PAPEL);

        }
    }
}
