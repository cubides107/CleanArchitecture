using CleanArchitecture.Application.ProductServices;
using CleanArchitecture.Domain.Models.ProductEntities;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ProductServices productServices;

        public ProductsController(ProductServices productServices)
        {
            this.productServices = productServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Register(string name, string description)
        {
            var product = Product.Build(name, description);

            await productServices.Register(product);

            return RedirectToAction("Index", "Home");
        }
    }
}
