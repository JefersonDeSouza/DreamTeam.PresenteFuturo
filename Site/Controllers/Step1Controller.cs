using Conversoes;
using Negocio.Cliente;
using Negocio.Interface;
using Site.Signatures;
using Site.ViewsModels;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class Step1Controller : Controller
    {
        private readonly IClienteNeg _clienteNeg;

        public Step1Controller()
        {
            _clienteNeg = new ClienteNeg();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(ClienteSignature clienteSignature)
        {
            if (!ModelState.IsValid)
                return View(clienteSignature);

            try
            {
                _clienteNeg.Salvar(ClienteSignatureConversor.ToDomain(clienteSignature));
                TempData["Mensagem"] = new MensagemVM() { CssClassName = "alert-success", Titulo = "Sucesso!", Mensagem= "Operação efetuada com sucesso." };
                return RedirectToAction("Cadastrar");
            }
            catch
            {
                TempData["Mensagem"] = new MensagemVM() { CssClassName = "alert-danger", Titulo = "Erro!", Mensagem = "Operação falhou." };
                return View("Create");
            }
        }

        // GET: Step1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Step1/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
