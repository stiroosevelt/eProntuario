using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class ACESSO
    {
        public long COD_ACESSO { get; set; }
        public long COD_PAPEL { get; set; }
        public long COD_FUNCIONALIDADE { get; set; }
        public string IND_CONSULTAR { get; set; }
        public string IND_INSERIR { get; set; }
        public string IND_EXCLUIR { get; set; }
        public string IND_ALTERAR { get; set; }
        public string IND_IMPRIMIR { get; set; }
        public virtual FUNCIONALIDADE FUNCIONALIDADE { get; set; }
        public virtual PAPEL PAPEL { get; set; }
    }
}
