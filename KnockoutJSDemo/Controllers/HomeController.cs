using System.Diagnostics;
using System.Web.Mvc;
using KnockoutJSDemo.Models;

namespace KnockoutJSDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Trace.Write("Hey, this is nice");
            Trace.TraceWarning("Oh, this could be bad.");
            return View("AddCandidate");
        }
        [HttpPost]
        public JsonResult Create(Candidate candidate)
        {
            //do the persistence logic here
            var message = "Candidate: " + candidate.FirstName + " Saved";
            return Json(message);
        }        
    }
}
