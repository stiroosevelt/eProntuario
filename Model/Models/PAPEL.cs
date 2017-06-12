using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class PAPEL
    {
        public PAPEL()
        {
            this.ACESSO = new List<ACESSO>();
            this.VINCULO_PROFISSIONAL = new List<VINCULO_PROFISSIONAL>();
        }

        public long COD_PAPEL { get; set; }
        public string NOM_PAPEL { get; set; }
        public string NUM_CBO { get; set; }
        public string IND_ATIVO { get; set; }
        public virtual ICollection<ACESSO> ACESSO { get; set; }
        public virtual ICollection<VINCULO_PROFISSIONAL> VINCULO_PROFISSIONAL { get; set; }
    }
}
