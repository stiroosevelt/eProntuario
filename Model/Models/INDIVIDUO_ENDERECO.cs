using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class INDIVIDUO_ENDERECO
    {
        public long COD_INDIVIDUO_ENDERECO { get; set; }
        public long COD_INDIVIDUO { get; set; }
        public long COD_BAIRRO { get; set; }
        public long COD_LOGRADOURO { get; set; }
        public int? NUM_ENDERECO { get; set; }
        public string DES_COMPLEMENTO { get; set; }
        public System.DateTime DAT_RESIDE_DESDE { get; set; }
        public string IND_ATIVO { get; set; }
        public virtual BAIRRO BAIRRO { get; set; }
        public virtual INDIVIDUO INDIVIDUO { get; set; }
        public virtual LOGRADOURO LOGRADOURO { get; set; }
    }
}
