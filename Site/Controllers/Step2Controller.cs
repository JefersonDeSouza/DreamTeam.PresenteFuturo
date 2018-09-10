using Negocio.Cliente;
using Negocio.Interface;
using Site.Conversoes;
using Site.Signatures;
using Site.ViewsModels;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class Step2Controller : Controller
    {
        private readonly IClienteNeg _clienteNeg;

        public Step2Controller()
        {
            _clienteNeg = new ClienteNeg();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Step2Signature step2Signature)
        {
            if (!ModelState.IsValid)
                return View(step2Signature);

            try
            {
                _clienteNeg.Salvar(Step2SignatureConversor.ToDomain(step2Signature));
                TempData["Mensagem"] = new MensagemVM() { CssClassName = "alert-success", Titulo = "Sucesso!", Mensagem = "Operação efetuada com sucesso." };
                return RedirectToAction("Cadastrar");
            }
            catch
            {
                TempData["Mensagem"] = new MensagemVM() { CssClassName = "alert-danger", Titulo = "Erro!", Mensagem = "Operação falhou." };
                return View("Cadastrar");
            }
        }
    }
}