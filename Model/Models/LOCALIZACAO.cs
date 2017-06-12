using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class LOCALIZACAO
    {
        public long COD_LOCALIZACAO { get; set; }
        public long COD_BAIRRO { get; set; }
        public long COD_LOGRADOURO { get; set; }
        public string NUM_CEP_INICIO { get; set; }
        public string NUM_CEP_FIM { get; set; }
        public virtual BAIRRO BAIRRO { get; set; }
        public virtual LOGRADOURO LOGRADOURO { get; set; }
    }
}
