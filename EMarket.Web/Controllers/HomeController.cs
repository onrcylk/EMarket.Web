using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EMarket.Web.Models;
using EMarket.Web.Interfaces;
using Microsoft.AspNetCore.Http;
using EMarket.ApplicationCore.Interfaces;

namespace EMarket.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeIndexViewModelService _homeIndexViewModelService;
        public HomeController(IHomeIndexViewModelService homeIndexViewModelService)
        {
            _homeIndexViewModelService = homeIndexViewModelService;
        }

        public IActionResult Index(int? cid, int? p)
        {
            // HttpContext.Session.SetString("ad", "ali");

            return View(_homeIndexViewModelService.GetHomeIndexViewModel(cid, p ?? 1, Constants.ITEMS_PER_PAGE));
        }

        public IActionResult Privacy([FromServices]IBasketService basketService)
        {
            basketService.AddItemToBasket(1,"Kola",3.5m,"",3);
            ViewBag.items = basketService.BasketItems;
           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
