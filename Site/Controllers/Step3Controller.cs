using Negocio.Cliente;
using Negocio.Interface;
using Site.Conversoes;
using Site.Signatures;
using Site.ViewsModels;
using System.Linq;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class Step3Controller : Controller
    {
        private readonly IClienteNeg _clienteNeg;

        public Step3Controller()
        {
            _clienteNeg = new ClienteNeg();
        }
        public ActionResult Consultar()
        {
            return Consultar(new Step3Signature { CPF = "111.111.111-01", NumeroMatricula = "123456" });
        }

        [HttpGet, HttpPost]
        public ActionResult Consultar(Step3Signature step3Signature)
        {
            if (!ModelState.IsValid)
                return View(step3Signature);

            try
            {
                var retornoConsulta = _clienteNeg.Consultar(Step3SignatureConversor.ToDomain(step3Signature));

                MapearResult(retornoConsulta, out Step3VM ret);
                return View(ret);
            }
            catch
            {
                TempData["Mensagem"] = new MensagemVM() { CssClassName = "alert-danger", Titulo = "Erro!", Mensagem = "Operação falhou." };
                return View("Consultar");
            }
        }

        private static void MapearResult(Dominio.Results.Step3Result retornoConsulta, out Step3VM ret)
        {
            ret = new Step3VM
            {
                DataEmissao = retornoConsulta.DataEmissao,
                Contribuicoes = retornoConsulta.Contribuicoes.Select(item =>
                {
                    return new ContribuicaoEventoVM
                    {
                        Contribuinte = item.Contribuinte,
                        ValorContruibuido = item.ValorContruibuido
                    };
                }).ToList(),
                Status = retornoConsulta.Status.Select(item =>
                {
                    return new StatusContribuicaoVM
                    {
                        Mensagem = item.Mensagem,
                        Status = item.Status
                    };
                }).ToList()
            };
        }
    }
}