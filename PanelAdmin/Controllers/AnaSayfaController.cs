using PanelAdmin.Models;
using System.Linq;
using System.Web.Mvc;

namespace PanelAdmin.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        MyDbContext c = new MyDbContext();
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }

        public PartialViewResult Ikonlar()
        {
            var deger = c.Ikonlars.ToList();

            return PartialView(deger);
        }
    }
}