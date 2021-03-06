using System;
using System.Collections.Generic;

namespace lab.Domain.Entities.Cadastro.Referencias
{
    public class Ref439
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
        public string Ncm { get; set; }
        public string NcmEx { get; set; }
        public string ExIpi { get; set; }
        public float? AliqPis { get; set; }
        public float? AliqCofins { get; set; }
    }
}