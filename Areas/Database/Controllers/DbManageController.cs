using App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Areas.Database.Controllers
{
    [Area("Database")]
    [Route("/database-manage/[action]")]
    public class DbManageController : Controller
    {
        private readonly AppDbContext _dbContext;

        public DbManageController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: DbManageController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeleteDb(){
            return View();
        }

        [TempData]
        public string StatusMessage { get; set; }
        [HttpPost]
        public async Task<IActionResult> DeleteDbAsync(){

            var success = await _dbContext.Database.EnsureDeletedAsync();
            StatusMessage = success ? "XOA OK" : "XOA ERROR";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Migrate(){
            await _dbContext.Database.MigrateAsync();
            StatusMessage = "Cap Nhat Db thanh cong";
            return RedirectToAction(nameof(Index));
        }
    }
}
