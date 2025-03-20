using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;
public class FirstController : Controller{
    private readonly ILogger<FirstController> _logger;
    private readonly ProductService _productService;
    public FirstController(ILogger<FirstController> logger, ProductService productService){
        _logger = logger;
        _productService = productService;
    }
    public string Index(){

        _logger.LogInformation("FirstController accessed");
        return "Hello from FirstController!";
    }

    [TempData]
    public string StatusMessage {get; set; }

    public IActionResult ViewProduct(int? id){
        var product = _productService.Where(p => p.Id == id).FirstOrDefault();
        if(product == null){
            // TempData["StatusMessage"] = "San pham ban yeu cau khong co";
            StatusMessage = "San pham ban yeu cau khong co";
            return Redirect(Url.Action("Index", "Home"));
        }

        // this.ViewData["product"] = product;
        // ViewData["Title"] = product.Name;
        // return View("ViewProduct2");
        ViewBag.product = product;
        return View("ViewProduct3");
    }

}