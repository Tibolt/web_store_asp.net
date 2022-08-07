using Microsoft.AspNetCore.Mvc;
using Online_Store.Data;
using Online_Store.Models;

namespace Online_Store.Controllers
{
    public class CartController : Controller
    {
        public OrderModel? Order { get; set; }
        private readonly ApplicationDbContext _db;
        public CartController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var CookieList = Request.Cookies.ToList();
            var objList = new List<Product>();
            foreach(var item in CookieList)
            {
                Console.WriteLine("Value: " + item.Value);
                int id = Int32.Parse(item.Value);
                objList.Add(item: _db.Products.Find(id)!);
            }
            return View(objList);
        }
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckoutPost(OrderModel order)
        {
            _db.Orders.Add(order);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
