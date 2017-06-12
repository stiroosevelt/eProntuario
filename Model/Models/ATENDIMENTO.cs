using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class ATENDIMENTO
    {
        public long COD_ATENDIMENTO { get; set; }
        public long COD_ESTABELECIMENTO { get; set; }
        public long COD_TIPO_ATENDIMENTO { get; set; }
        public long COD_INDIVIDUO { get; set; }
        public long DAT_ATENDIMENTO { get; set; }
        public Nullable<long> COD_VINCULO_PROFISSIONAL { get; set; }
        public virtual ESTABELECIMENTO ESTABELECIMENTO { get; set; }
        public virtual INDIVIDUO INDIVIDUO { get; set; }
        public virtual TIPO_ATENDIMENTO TIPO_ATENDIMENTO { get; set; }
        public virtual VINCULO_PROFISSIONAL VINCULO_PROFISSIONAL { get; set; }
    }
}
