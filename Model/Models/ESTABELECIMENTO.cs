using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class ESTABELECIMENTO
    {
        public ESTABELECIMENTO()
        {
            this.ATENDIMENTO = new List<ATENDIMENTO>();
            this.VINCULO_PROFISSIONAL = new List<VINCULO_PROFISSIONAL>();
        }

        public long COD_ESTABELECIMENTO { get; set; }
        public long COD_CLIENTE { get; set; }
        public string NOM_ESTABELECIMENTO { get; set; }
        public virtual ICollection<ATENDIMENTO> ATENDIMENTO { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual ICollection<VINCULO_PROFISSIONAL> VINCULO_PROFISSIONAL { get; set; }
    }
}
