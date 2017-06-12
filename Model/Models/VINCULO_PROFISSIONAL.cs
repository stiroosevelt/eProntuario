using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class VINCULO_PROFISSIONAL
    {
        public VINCULO_PROFISSIONAL()
        {
            this.ATENDIMENTOes = new List<ATENDIMENTO>();
        }

        public long COD_VINCULO_PROFISSIONAL { get; set; }
        public Nullable<long> COD_PROFISSIONAL { get; set; }
        public Nullable<long> COD_ESTABELECIMENTO { get; set; }
        public Nullable<long> COD_PAPEL { get; set; }
        public virtual ICollection<ATENDIMENTO> ATENDIMENTOes { get; set; }
        public virtual ESTABELECIMENTO ESTABELECIMENTO { get; set; }
        public virtual PAPEL PAPEL { get; set; }
        public virtual PROFISSIONAL PROFISSIONAL { get; set; }
    }
}
