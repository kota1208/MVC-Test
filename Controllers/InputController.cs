using Microsoft.AspNetCore.Mvc;

namespace MVC_Test.Controllers
{
    public class InputController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        //CSRF対策用のトークン
        [ValidateAntiForgeryToken]

        public IActionResult Index(Models.InputModel model)
        {

            string name = model.name;

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //アクセスを行っているかがわからなかったため、文字列を返すかでテストを行った
            //return Content("piyo")

            //ルートからのパス
            //return View("~/Views/Input/Complate.cshtml", model);

            //カレントディレクトリ(プロジェクト)からの指定
            return View("Views/Input/Complate.cshtml", model);


        }
    }
}
