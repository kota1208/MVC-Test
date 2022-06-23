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
            List<ProductEntity> result =ProductDapper.GetProductAll();

            ProductEntity product = result[0];

            ViewBag.result = result;
           
            return View("Views/InputDapper/result.cshtml", product);;
        }

        
        [HttpGet]
        //CSRF対策用のトークン
        [ValidateAntiForgeryToken]
        public IActionResult DapperSelectGet()
        {
            //Dapperクラスを別に作成
            List<ProductEntity> result = ProductDapper.GetProductAll();

            ProductEntity product = result[0];

            ViewBag.result = result;

            return View("Views/InputDapper/result.cshtml", product); ;
        }
    }
}
