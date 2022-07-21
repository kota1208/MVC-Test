using Microsoft.AspNetCore.Mvc;
using MVC_Test.dapper;
using MVC_Test.Models;
using System.Collections;

namespace MVC_Test.Controllers
{
    public class InputDapperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        //CSRF対策用のトークン
        [ValidateAntiForgeryToken]
        public IActionResult DapperSelect()
        {
            //Dapperクラスを別に作成
            //List<ProductEntity> result =ProductDapper.GetProductAll();

            List<CityEntity> result = ProductDapper.GetProductAll();
            //ProductEntity product = result[0];
            CityEntity city = result[0];

            ViewBag.result = result;
           
            return View("Views/InputDapper/result.cshtml", city);;
        }




        [HttpGet]
        //CSRF対策用のトークン 有効にするとアクセス時に、エラーになる
        //[ValidateAntiForgeryToken]
        public IActionResult GetMethod()
        {
           

            return View("Views/InputDapper/resultGet.cshtml"); 
        }



    }
}
