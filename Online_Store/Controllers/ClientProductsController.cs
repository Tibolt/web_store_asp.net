using Microsoft.AspNetCore.Mvc;
using Online_Store.Data;
using Online_Store.Models;

namespace Online_Store.Controllers
{
    public class ClientProductsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ClientProductsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> objList = _db.Products;
            return View(objList);
        }
        public IActionResult AddToCart(int id)
        {
            string itemID = id.ToString();
            Response.Cookies.Append("item" + itemID, itemID);
            return RedirectToAction("Index");

        }
    }
}
