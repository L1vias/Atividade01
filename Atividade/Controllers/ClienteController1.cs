using Atividade.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atividade.Controllers
{
    public class ClienteController1 : Controller
    {
        public IActionResult GetClientes()
        {
            Cliente c1 = new Cliente(1, "Livia", "Livia@example.com", "988381891", new DateOnly(2006, 7, 12));
            Cliente c2 = new Cliente(2, "Ana Julia", "Julia@example.com", "988078439", new DateOnly(2007, 1, 3));
            Cliente c3 = new Cliente(3, "Ana Clara", "AnaClara@example.com", "1234-5678", new DateOnly(2007, 5, 20));
            Cliente c4 = new Cliente(4, "Beatriz", "Beatriz@example.com", "1234-5678", new DateOnly(2007, 4, 8));
            Cliente c5 = new Cliente(5, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            return View();
        }
    }
}
