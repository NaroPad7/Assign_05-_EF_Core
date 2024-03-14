using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Northwind.Controllers
{
    public class ProductController(DataContext db) : Controller
    {
        private readonly DataContext _dataContext = db;

        public IActionResult Category() => View(_dataContext.Categories.OrderBy(b => b.CategoryName));
        public IActionResult Index(int id) => View(
    
        _dataContext.Products.Where(p => p.CategoryId == id)
    );

    }
}