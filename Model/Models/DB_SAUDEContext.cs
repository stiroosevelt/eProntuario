using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Model.Models.Mapping;

namespace Model.Models
{
    public partial class DB_SAUDEContext : DbContext
    {
        static DB_SAUDEContext()
        {
            Database.SetInitializer<DB_SAUDEContext>(null);
        }

        public DB_SAUDEContext()
            : base("Name=DB_SAUDEContext")
        {
        }

        public DbSet<ACESSO> ACESSO { get; set; }
        public DbSet<ATENDIMENTO> ATENDIMENTO { get; set; }
        public DbSet<BAIRRO> BAIRRO { get; set; }
        public DbSet<CIDADE> CIDADE { get; set; }
        public DbSet<CLIENTE> CLIENTE { get; set; }
        public DbSet<ESTABELECIMENTO> ESTABELECIMENTO { get; set; }
        public DbSet<ESTADO> ESTADO { get; set; }
        public DbSet<FUNCIONALIDADE> FUNCIONALIDADE { get; set; }
        public DbSet<INDIVIDUO> INDIVIDUO { get; set; }
        public DbSet<INDIVIDUO_ENDERECO> INDIVIDUO_ENDERECO { get; set; }
        public DbSet<LOCALIZACAO> LOCALIZACAO { get; set; }
        public DbSet<LOGRADOURO> LOGRADOURO { get; set; }
        public DbSet<PAIS> PAIS { get; set; }
        public DbSet<PAPEL> PAPEL { get; set; }
        public DbSet<PROFISSIONAL> PROFISSIONAL { get; set; }
        public DbSet<TIPO_ATENDIMENTO> TIPO_ATENDIMENTO { get; set; }
        public DbSet<TIPO_LOGRADOURO> TIPO_LOGRADOURO { get; set; }
        public DbSet<USUARIO> USUARIOs { get; set; }
        public DbSet<VINCULO_PROFISSIONAL> VINCULO_PROFISSIONAL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ACESSOMap());
            modelBuilder.Configurations.Add(new ATENDIMENTOMap());
            modelBuilder.Configurations.Add(new BAIRROMap());
            modelBuilder.Configurations.Add(new CIDADEMap());
            modelBuilder.Configurations.Add(new CLIENTEMap());
            modelBuilder.Configurations.Add(new ESTABELECIMENTOMap());
            modelBuilder.Configurations.Add(new ESTADOMap());
            modelBuilder.Configurations.Add(new FUNCIONALIDADEMap());
            modelBuilder.Configurations.Add(new INDIVIDUOMap());
            modelBuilder.Configurations.Add(new INDIVIDUO_ENDERECOMap());
            modelBuilder.Configurations.Add(new LOCALIZACAOMap());
            modelBuilder.Configurations.Add(new LOGRADOUROMap());
            modelBuilder.Configurations.Add(new PAISMap());
            modelBuilder.Configurations.Add(new PAPELMap());
            modelBuilder.Configurations.Add(new PROFISSIONALMap());
            modelBuilder.Configurations.Add(new TIPO_ATENDIMENTOMap());
            modelBuilder.Configurations.Add(new TIPO_LOGRADOUROMap());
            modelBuilder.Configurations.Add(new USUARIOMap());
            modelBuilder.Configurations.Add(new VINCULO_PROFISSIONALMap());
            
            //VERIFICA AS PROPRIEDADES QUE INICIAM COM "IND" E APLICA O TIPO DE DADOS "CHAR" PARA TODAS AS OUTRAS APLICA-SE VARCHAR
            //CONFORME PADRONIZAÇÃO DO BANCO DE DADOS.
            modelBuilder.Properties<string>()
                .Where(p => p.Name.ToString().Substring(0, 3) == "IND")
                .Configure(p => p.HasColumnType("char"));

            modelBuilder.Properties<string>()
                .Where(p => p.Name.ToString().Substring(0, 3) != "IND")
                .Configure(p => p.HasColumnType("varchar"));
        }
    }
}
