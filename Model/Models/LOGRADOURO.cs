using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class LOGRADOURO
    {
        public LOGRADOURO()
        {
            this.CLIENTE = new List<CLIENTE>();
            this.INDIVIDUO_ENDERECO = new List<INDIVIDUO_ENDERECO>();
            this.LOCALIZACAO = new List<LOCALIZACAO>();
        }

        public long COD_LOGRADOURO { get; set; }
        public long COD_TIPO_LOGRADOURO { get; set; }
        public string NOM_LOGRADOURO { get; set; }
        public string IND_ATIVO { get; set; }
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }
        public virtual ICollection<INDIVIDUO_ENDERECO> INDIVIDUO_ENDERECO { get; set; }
        public virtual ICollection<LOCALIZACAO> LOCALIZACAO { get; set; }
        public virtual TIPO_LOGRADOURO TIPO_LOGRADOURO { get; set; }
    }
}
