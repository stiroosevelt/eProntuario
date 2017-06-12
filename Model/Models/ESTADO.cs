using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class ESTADO
    {
        public ESTADO()
        {
            this.CIDADE = new List<CIDADE>();
        }

        public long COD_ESTADO { get; set; }
        public long COD_PAIS { get; set; }
        public string NOM_ESTADO { get; set; }
        public string DES_SIGLA_ESTADO { get; set; }
        public string IND_ATIVO { get; set; }
        public virtual ICollection<CIDADE> CIDADE { get; set; }
        public virtual PAIS PAIS { get; set; }
    }
}
