using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class PlanetController : Controller
    {
        private readonly PlanetService _planetService;
        private readonly ILogger<PlanetService> _logger;

        public PlanetController(PlanetService planetService, ILogger<PlanetService> logger)
        {
            _planetService = planetService;
            _logger = logger;
        }

        // GET: Planet
        [Route("danh-sach-cac-hanh-tinh.html")]
        public ActionResult Index()
        {
            return View();
        }

        [BindProperty(SupportsGet = true, Name = "action")]
        public string Name { get; set; } // Action ~ PlanetModel
        public IActionResult Mercury(){
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Earth(){
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Jupiter(){
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Mars(){
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Neptune(){
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Saturn(){
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Uranus(){
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Venus(){
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult PlanetInfo(int id) {
            var planet = _planetService.Where(p => p.Id == id).FirstOrDefault();
            return View("Detail", planet);
        }
    }
}
