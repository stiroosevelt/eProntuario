using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class USUARIOMap : EntityTypeConfiguration<USUARIO>
    {
        public USUARIOMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_USUARIO);

            // Properties
            this.Property(t => t.NOM_USUARIO)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.NUM_CPF)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DES_LOGIN)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DES_SENHA)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IND_BLOQUEADO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.IND_ATIVO)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("USUARIO");
            this.Property(t => t.COD_USUARIO).HasColumnName("COD_USUARIO");
            this.Property(t => t.NOM_USUARIO).HasColumnName("NOM_USUARIO");
            this.Property(t => t.NUM_CPF).HasColumnName("NUM_CPF");
            this.Property(t => t.DES_LOGIN).HasColumnName("DES_LOGIN");
            this.Property(t => t.DES_SENHA).HasColumnName("DES_SENHA");
            this.Property(t => t.DAT_ULTIMO_ACESSO).HasColumnName("DAT_ULTIMO_ACESSO");
            this.Property(t => t.DAT_VALIDADE_SENHA).HasColumnName("DAT_VALIDADE_SENHA");
            this.Property(t => t.IND_BLOQUEADO).HasColumnName("IND_BLOQUEADO");
            this.Property(t => t.IND_ATIVO).HasColumnName("IND_ATIVO");
        }
    }
}
