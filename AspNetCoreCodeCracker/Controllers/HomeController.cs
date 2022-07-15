using AspNetCoreCodeCracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreCodeCracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                string usuario = "bertuzziTeste";
                string senha = "YUEIYAjhas1";
                string nome = "Thiago";
                string sobrenome = "Bertuzzi";
                string nomeCompleto = nome + " " + sobrenome;

                Console.WriteLine("Nome Completo: {0} {1}", nome, sobrenome);

                dynamic retorno = new
                {
                    Usuario = usuario,
                    Senha = senha,
                    NomeCompleto = nomeCompleto
                };

                return View(retorno);
            }
            catch
            {
                Console.WriteLine("Eu erro");
                return View();
            }
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
