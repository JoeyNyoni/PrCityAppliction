using GBTC.Models;
using GBTC.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace GBTC.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Events
        public ActionResult Create()
        {
            var viewModel = new EventsFormViewModel
            {
                Types = _context.Types.ToList()
            };
            return View(viewModel);
        }
    }
}