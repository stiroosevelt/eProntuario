using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class INDIVIDUOMap : EntityTypeConfiguration<INDIVIDUO>
    {
        public INDIVIDUOMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_INDIVIDUO);

            // Properties
            this.Property(t => t.NOM_INDIVIDUO)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.NUM_CNS)
                .HasMaxLength(15);

            this.Property(t => t.IND_SEXO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NOM_MAE)
                .HasMaxLength(200);

            this.Property(t => t.NOM_PAI)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("INDIVIDUO");
            this.Property(t => t.COD_INDIVIDUO).HasColumnName("COD_INDIVIDUO");
            this.Property(t => t.NOM_INDIVIDUO).HasColumnName("NOM_INDIVIDUO");
            this.Property(t => t.NUM_CNS).HasColumnName("NUM_CNS");
            this.Property(t => t.DAT_NASCIMENTO).HasColumnName("DAT_NASCIMENTO");
            this.Property(t => t.IND_SEXO).HasColumnName("IND_SEXO");
            this.Property(t => t.NOM_MAE).HasColumnName("NOM_MAE");
            this.Property(t => t.NOM_PAI).HasColumnName("NOM_PAI");
            this.Property(t => t.DAT_CADASTRO).HasColumnName("DAT_CADASTRO");
            this.Property(t => t.COD_PROFISSIONAL).HasColumnName("COD_PROFISSIONAL");
            this.Property(t => t.DAT_ULTIMA_ALTERACAO).HasColumnName("DAT_ULTIMA_ALTERACAO");

            // Relationships
            this.HasRequired(t => t.PROFISSIONAL)
                .WithMany(t => t.INDIVIDUO)
                .HasForeignKey(d => d.COD_PROFISSIONAL);

        }
    }
}
