using Microsoft.AspNetCore.Mvc;

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
        public IActionResult DapperInsert(Models.InputModel model)
        {
            //Dapperクラスを別に作成
            return null;
        }
    }
}
