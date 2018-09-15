using System;
using System.Collections.Generic;

namespace Site.ViewsModels
{
    public class Step3VM
    {
        public DateTime DataEmissao { get; set; }
        public IList<ContribuicaoEventoVM> Contribuicoes { get; set; }
        public IList<StatusContribuicaoVM> Status { get; set; }
    }
}