using Microsoft.AspNetCore.Mvc;

namespace MVC_Test.Controllers
{
    public class AeonController : Controller
    {
        public IActionResult Index()
        {
            return View("Views/Aeon/Index.cshtml");
        }


        //購入した商品をすべて取得する
        [HttpGet]
        public static IActionResult ShowBuyItems()
        {

            return null;
        }
    }
}
