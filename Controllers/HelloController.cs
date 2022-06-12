using Microsoft.AspNetCore.Mvc;

namespace MVC_Test.Controllers
{
    //https://qiita.com/yagi405/items/5591d1f581db7978d3e8
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            //プロパティを作ってみる
            ViewBag.PropertiestTest = "プロパティーです";


            ViewBag.Message = "Hello World";
            ViewBag.Title = "HelloController";
            ViewData["Now"]=DateTime.Now;
            //Content はテキストデータを戻す。
            //return Content("Hello World");

            return View();
        }

        //別ページにリダイレクトを行う
        public RedirectResult Redirect()
        {
            return Redirect("https://www.google.com/");
        }
    }
}
