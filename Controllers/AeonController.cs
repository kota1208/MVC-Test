using Microsoft.AspNetCore.Mvc;
using MVC_Test.Models;

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
            //Modelの作成
            AeionItemsEntity model = new AeionItemsEntity();



            return null;
        }
    }
}
