using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public void SomePage(int id)
        {
            Response.Write($"<h1>{id}</h1>");
        }

        [Route("foo/bar/{word}")]
        public void Something(string word)
        {
            Response.Write($"<h1>NO WAY!!! with word: {word}</h1>");
        }

        [Route("simchas/{simchaId}/contributions")]
        public void ShowContributions(int simchaId, string word)
        {
            Response.Write($"<h1>SO COOL! with simcha id: {simchaId}</h1>");
        }
    }

}