using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StarWeb.Data;
using StarWeb.Model;

namespace StarWeb.Pages.Categories
{
    public class IndexModel : PageModel
    {
       
        private readonly ApplicationDbContext _db;
        public IEnumerable<Category> Categories { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Categories = _db.Categories;
        }
    }
}
