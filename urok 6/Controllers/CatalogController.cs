using Microsoft.AspNetCore.Mvc;

namespace urok_6.Controllers
{
    [Route("catalog/{category}/filter")]
    public class CatalogController : Controller
    {
        [HttpGet]
        public IActionResult Filter(string category, decimal minPrice, decimal maxPrice)
        {
            ViewBag.Category = category;
            ViewBag.MinPrice = minPrice;
            ViewBag.MaxPrice = maxPrice;

            return View();
        }
    }
}
