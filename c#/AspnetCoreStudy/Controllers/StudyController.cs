using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreStudy.Controllers
{
    public class StudyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //주소를 메서드로 연결하는부분
        public IActionResult Java()
        {
            return View();
        }
        public IActionResult CSharp()
        {
            return View();
        }
        public IActionResult Cpp()
        {
            return View();
        }
    }
}
