using AspnetNote.MVC6.DataContext;
using AspnetNote.MVC6.Models;
using AspnetNote.MVC6.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspnetNote.MVC6.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            //ID,Password
            if (ModelState.IsValid)
            {
                using (var db = new AspnetNoteDbContext())
                {
                    //Linq 쿼리식 - 메서드 체이닝
                    // => 람다식
                    var user = db.Users.FirstOrDefault(u => u.UserId.Equals(model.UserId) && u.UserPassWord.Equals(model.UserPassWord));
                   
                    if(user != null)
                    { 
                        //로그인성공
                        //session
                        HttpContext.Session.SetInt32("USER_LOGIN_KEY",user.UserNo);
                        return RedirectToAction("LoginSuccess", "Home");
                    }
                        ModelState.AddModelError(string.Empty, "사용자 ID 혹은 비밀번호가 올바르지 않습니다.");
                    
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            return RedirectToAction("Index", "Home");
        }
        /// <summary>
        /// 회원가입
        /// </summary>
        /// <returns></returns>
        
        public IActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                
                using(var db = new AspnetNoteDbContext())
                {
                    db.Users.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("index", "Home");
            }
            return View();
        }
    }
}
