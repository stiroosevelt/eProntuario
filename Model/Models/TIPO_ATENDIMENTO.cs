using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class TIPO_ATENDIMENTO
    {
        public TIPO_ATENDIMENTO()
        {
            this.ATENDIMENTO = new List<ATENDIMENTO>();
        }

        public long COD_TIPO_ATENDIMENTO { get; set; }
        public string NOM_TIPO_ATENDIMENTO { get; set; }
        public string DES_TIPO_ATENDIMENTO { get; set; }
        public string IND_ATIVO { get; set; }
        public virtual ICollection<ATENDIMENTO> ATENDIMENTO { get; set; }
    }
}
