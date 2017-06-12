using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class PROFISSIONALMap : EntityTypeConfiguration<PROFISSIONAL>
    {
        public PROFISSIONALMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_PROFISSIONAL);

            // Properties
            this.Property(t => t.NOM_PROFISSIONAL)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.NUM_CPF)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PROFISSIONAL");
            this.Property(t => t.COD_PROFISSIONAL).HasColumnName("COD_PROFISSIONAL");
            this.Property(t => t.COD_USUARIO).HasColumnName("COD_USUARIO");
            this.Property(t => t.COD_PAPEL).HasColumnName("COD_PAPEL");
            this.Property(t => t.NOM_PROFISSIONAL).HasColumnName("NOM_PROFISSIONAL");
            this.Property(t => t.NUM_CPF).HasColumnName("NUM_CPF");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PROFISSIONAL)
                .HasForeignKey(d => d.COD_USUARIO);

        }
    }
}
