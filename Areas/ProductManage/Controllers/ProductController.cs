using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Area("ProductManage")]
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        private readonly ILogger<ProductService> _logger;

        public ProductController(ProductService productService, ILogger<ProductService> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        // GET: ProductController
        public ActionResult Index()
        {
            var products = _productService.OrderBy(p => p.Name).ToList();
            return View(products);
        }

    }
}
