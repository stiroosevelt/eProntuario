using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class FUNCIONALIDADE
    {
        public FUNCIONALIDADE()
        {
            this.ACESSO = new List<ACESSO>();
        }

        public long COD_FUNCIONALIDADE { get; set; }
        public string NOM_FUNCIONALIDADE { get; set; }
        public virtual ICollection<ACESSO> ACESSO { get; set; }
    }
}
