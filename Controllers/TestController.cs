using Microsoft.AspNetCore.Mvc;

namespace MVC_Test.Controllers
{
    public class TestController : Controller
    {
        //作成手順。追加ｰ>コントローラーｰ>からのコントローラ

        //アクションメソッド
        public IActionResult Index()
        {
            return View();
        }
    }
}
