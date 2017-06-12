using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class TIPO_LOGRADOURO
    {
        public TIPO_LOGRADOURO()
        {
            this.LOGRADOURO = new List<LOGRADOURO>();
        }

        public long COD_TIPO_LOGRADOURO { get; set; }
        public string NOM_TIPO_LOGRADOURO { get; set; }
        public string DES_SIGLA_LOGRADOURO { get; set; }
        public string IND_ATIVO { get; set; }
        public virtual ICollection<LOGRADOURO> LOGRADOURO { get; set; }
    }
}
