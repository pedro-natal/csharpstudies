using _13___MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace _13___MVC.Controllers
{
    public class AddressController : Controller
    {
        private readonly ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }

        // GET: AddressController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Addresss/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Address/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressModel data)
        {
            if (ModelState.IsValid == false)
            {
                {
                    _logger.LogWarning("The user submitted an invalid Address upon Create.");
                    return View();
                }
            }
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
