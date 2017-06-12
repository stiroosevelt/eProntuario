using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class INDIVIDUO
    {
        public INDIVIDUO()
        {
            this.ATENDIMENTO = new List<ATENDIMENTO>();
            this.INDIVIDUO_ENDERECO = new List<INDIVIDUO_ENDERECO>();
        }

        public long COD_INDIVIDUO { get; set; }
        public string NOM_INDIVIDUO { get; set; }
        public string NUM_CNS { get; set; }
        public System.DateTime DAT_NASCIMENTO { get; set; }
        public string IND_SEXO { get; set; }
        public string NOM_MAE { get; set; }
        public string NOM_PAI { get; set; }
        public System.DateTime DAT_CADASTRO { get; set; }
        public long COD_PROFISSIONAL { get; set; }
        public System.DateTime DAT_ULTIMA_ALTERACAO { get; set; }
        public virtual ICollection<ATENDIMENTO> ATENDIMENTO { get; set; }
        public virtual ICollection<INDIVIDUO_ENDERECO> INDIVIDUO_ENDERECO { get; set; }
        public virtual PROFISSIONAL PROFISSIONAL { get; set; }
    }
}
