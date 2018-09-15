using System;
using System.Collections.Generic;

namespace Dominio.Results
{
    public class Step3Result
    {
        public DateTime DataEmissao { get; set; }
        public IList<ContribuicaoEventoResult> Contribuicoes { get; set; }
        public IList<StatusContribuicaoResult> Status { get; set; }
    }
}
