using System.Diagnostics;
using AspnetCoreStudy.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreStudy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*var firstUser = new User();
            firstUser.No = 1;
            firstUser.Name = "홍길동";*/
            List<User> users = new List<User>();
            for (int i = 0; i < 3; i++)
            {
                var UserInfo = new User
                {
                    No = i,
                    Name = "테스트" + i
                };
                users.Add(UserInfo);
            }
            
            var KUser = new User
            {
                No = 1,
                Name = "홍길동"
            };
            ViewBag.User = KUser;
            ViewBag.Users = users;
            return View();
            /*return View(User);*/
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}