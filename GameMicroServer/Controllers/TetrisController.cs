using Microsoft.AspNetCore.Mvc;

namespace MS_Tetris.Controllers
{
    public class TetrisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
