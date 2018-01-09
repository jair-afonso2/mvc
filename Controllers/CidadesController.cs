using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAplicacao.Controllers
{
    public class CidadesController:Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}