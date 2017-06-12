using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class BAIRRO
    {
        public BAIRRO()
        {
            this.CLIENTE = new List<CLIENTE>();
            this.INDIVIDUO_ENDERECO = new List<INDIVIDUO_ENDERECO>();
            this.LOCALIZACAO = new List<LOCALIZACAO>();
        }

        public long COD_BAIRRO { get; set; }
        public long COD_CIDADE { get; set; }
        public string NOM_BAIRRO { get; set; }
        public string IND_ATIVO { get; set; }
        public virtual CIDADE CIDADE { get; set; }
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }
        public virtual ICollection<INDIVIDUO_ENDERECO> INDIVIDUO_ENDERECO { get; set; }
        public virtual ICollection<LOCALIZACAO> LOCALIZACAO { get; set; }
    }
}
