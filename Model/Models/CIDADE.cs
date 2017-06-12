using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class CIDADE
    {
        public CIDADE()
        {
            this.BAIRRO = new List<BAIRRO>();
            this.CLIENTE = new List<CLIENTE>();
        }

        public long COD_CIDADE { get; set; }
        public long COD_ESTADO { get; set; }
        public string COD_IBGE { get; set; }
        public string NOM_CIDADE { get; set; }
        public string NUM_CEP_PADRAO { get; set; }
        public string IND_ATIVO { get; set; }
        public virtual ICollection<BAIRRO> BAIRRO { get; set; }
        public virtual ESTADO ESTADO { get; set; }
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }
    }
}
