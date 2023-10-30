using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StarWeb.Data;
using StarWeb.Model;

namespace StarWeb.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        
        public Category Category { get; set; }
        
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            Category = _db.Categories.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
               _db.Categories.Update(Category);
               _db.SaveChanges();
                TempData["success"] = "Category Updated successfully";
                return RedirectToPage("Index");
            }
            return Page();

        }
    }
}


