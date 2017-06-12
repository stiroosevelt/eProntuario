using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class CLIENTE
    {
        public CLIENTE()
        {
            this.ESTABELECIMENTO = new List<ESTABELECIMENTO>();
        }

        public long COD_CLIENTE { get; set; }
        public string NOM_CLIENTE { get; set; }
        public string NUM_CONTRATO { get; set; }
        public string NOM_RESPONSAVEL { get; set; }
        public string DES_EMAIL { get; set; }
        public long COD_CIDADE { get; set; }
        public Nullable<long> COD_BAIRRO { get; set; }
        public Nullable<long> COD_LOGRADOURO { get; set; }
        public virtual BAIRRO BAIRRO { get; set; }
        public virtual CIDADE CIDADE { get; set; }
        public virtual LOGRADOURO LOGRADOURO { get; set; }
        public virtual ICollection<ESTABELECIMENTO> ESTABELECIMENTO { get; set; }
    }
}
