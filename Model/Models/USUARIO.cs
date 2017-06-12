using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.PROFISSIONAL = new List<PROFISSIONAL>();
        }

        public long COD_USUARIO { get; set; }
        public string NOM_USUARIO { get; set; }
        public string NUM_CPF { get; set; }
        public string DES_LOGIN { get; set; }
        public string DES_SENHA { get; set; }
        public System.DateTime DAT_ULTIMO_ACESSO { get; set; }
        public System.DateTime DAT_VALIDADE_SENHA { get; set; }
        public string IND_BLOQUEADO { get; set; }
        public string IND_ATIVO { get; set; }
        public virtual ICollection<PROFISSIONAL> PROFISSIONAL { get; set; }
    }
}
