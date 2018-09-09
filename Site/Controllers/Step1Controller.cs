using Conversoes;
using Negocio.Cliente;
using Negocio.Interface;
using Site.Signatures;
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

        // GET: Step1
        public ActionResult Index()
        {
            return View("Create");
        }

        // GET: Step1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Step1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Step1/Create
        [HttpPost]
        public ActionResult Create(ClienteSignature clienteSignature)
        {
            try
            {
                // TODO: Add insert logic here
                _clienteNeg.Salvar(ClienteSignatureConversor.ToDomain(clienteSignature));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
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
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Step1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Step1/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
