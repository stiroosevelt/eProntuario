using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class PAIS
    {
        public PAIS()
        {
            this.ESTADO = new List<ESTADO>();
        }

        public long COD_PAIS { get; set; }
        public string NOM_PAIS { get; set; }
        public string DES_SIGLA_PAIS { get; set; }
        public string IND_ATIVO { get; set; }
        public virtual ICollection<ESTADO> ESTADO { get; set; }
    }
}
