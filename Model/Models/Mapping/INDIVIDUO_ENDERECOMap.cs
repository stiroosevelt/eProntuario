using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class INDIVIDUO_ENDERECOMap : EntityTypeConfiguration<INDIVIDUO_ENDERECO>
    {
        public INDIVIDUO_ENDERECOMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_INDIVIDUO_ENDERECO);

            // Properties
            this.Property(t => t.DES_COMPLEMENTO)
                .HasMaxLength(200);

            this.Property(t => t.IND_ATIVO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("INDIVIDUO_ENDERECO");
            this.Property(t => t.COD_INDIVIDUO_ENDERECO).HasColumnName("COD_INDIVIDUO_ENDERECO");
            this.Property(t => t.COD_INDIVIDUO).HasColumnName("COD_INDIVIDUO");
            this.Property(t => t.COD_BAIRRO).HasColumnName("COD_BAIRRO");
            this.Property(t => t.COD_LOGRADOURO).HasColumnName("COD_LOGRADOURO");
            this.Property(t => t.NUM_ENDERECO).HasColumnName("NUM_ENDERECO");
            this.Property(t => t.DES_COMPLEMENTO).HasColumnName("DES_COMPLEMENTO");
            this.Property(t => t.DAT_RESIDE_DESDE).HasColumnName("DAT_RESIDE_DESDE");
            this.Property(t => t.IND_ATIVO).HasColumnName("IND_ATIVO");

            // Relationships
            this.HasRequired(t => t.BAIRRO)
                .WithMany(t => t.INDIVIDUO_ENDERECO)
                .HasForeignKey(d => d.COD_BAIRRO);
            this.HasRequired(t => t.INDIVIDUO)
                .WithMany(t => t.INDIVIDUO_ENDERECO)
                .HasForeignKey(d => d.COD_INDIVIDUO);
            this.HasRequired(t => t.LOGRADOURO)
                .WithMany(t => t.INDIVIDUO_ENDERECO)
                .HasForeignKey(d => d.COD_LOGRADOURO);

        }
    }
}
