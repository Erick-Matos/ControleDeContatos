using ControleDeContatos.Models;
using ControleDeContatos.Repositrio;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;

        }
    public IActionResult Index()
        {
            List <ContatoModel> contato = _contatoRepositorio.BuscarTodos();

            return View(contato);
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
       
                _contatoRepositorio.Adicionar(contato);
                return RedirectToAction("Index");
                //return View(contato);
        }
    }
}
