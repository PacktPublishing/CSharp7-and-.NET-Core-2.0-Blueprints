using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMailValidation.Models;
using System.Net.Http;

namespace CoreMailValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ValidateLogin(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var email = model.Email;
                string azFuncReturn = await ValidateEmail(model.Email);

                if (azFuncReturn.Contains("false"))
                {
                    TempData["message"] = "The email address entered is incorrect. Please enter again.";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return Content("You are logged in now.");
                }                
            }
            else
            {
                return View();
            }

        }


        private async Task<string> ValidateEmail(string emailToValidate)
        {
            string azureBaseUrl = "https://core-mail-validation.azurewebsites.net/api/HttpTriggerCSharp1";
            string urlQueryStringParams = $"?code=/IS4OJ3T46quiRzUJTxaGFenTeIVXyyOdtBFGasW9dUZ0snmoQfWoQ==&email={emailToValidate}";

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync($"{azureBaseUrl}{urlQueryStringParams}"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                        else
                            return "";
                    }
                }
            }
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
