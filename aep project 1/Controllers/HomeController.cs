using aep_project_1.Models;
using System.Linq;
using System.Web.Mvc;

namespace aep_project_1.Controllers
{
    public class HomeController : Controller
    {
        AepEntities db = new AepEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Improvements()
        {
            return View(db.SCORECARD_FACT.ToList());
        }
        public ActionResult Safety()
        {
            return View(db.SCORECARD_FACT.ToList());
        }
        public ActionResult OMetrics()
        {
            return View(db.SCORECARD_FACT.ToList());
        }
        public ActionResult Projects()
        {
            return View(db.SCORECARD_FACT.ToList());
        }
        public ActionResult Culture()
        {
            return View(db.SCORECARD_FACT.ToList());
        }
        public ActionResult Employee_Profile()
        {
            return View(db.SCORECARD_FACT.ToList());
        }
        public PartialViewResult IframeAction()
        {
            return PartialView();
        }


    }
}
