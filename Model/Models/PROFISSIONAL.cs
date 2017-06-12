using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class PROFISSIONAL
    {
        public PROFISSIONAL()
        {
            this.INDIVIDUO = new List<INDIVIDUO>();
            this.VINCULO_PROFISSIONAL = new List<VINCULO_PROFISSIONAL>();
        }

        public long COD_PROFISSIONAL { get; set; }
        public Nullable<long> COD_USUARIO { get; set; }
        public long COD_PAPEL { get; set; }
        public string NOM_PROFISSIONAL { get; set; }
        public string NUM_CPF { get; set; }
        public virtual ICollection<INDIVIDUO> INDIVIDUO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<VINCULO_PROFISSIONAL> VINCULO_PROFISSIONAL { get; set; }
    }
}
