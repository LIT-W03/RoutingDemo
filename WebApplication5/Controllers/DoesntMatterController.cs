using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    [RoutePrefix("avrumi")]
    [Route("{action}")]
    public class DoesntMatterController : Controller
    {
        public void Index()
        {
            Response.Write("<h1>Look at the URL!!</h1>");
        }

        [Route("friedman/nothing/else")]
        public void Bar()
        {
            Response.Write("<h1>Look at the URL again!!!!</h1>");
        }
       
    }
}