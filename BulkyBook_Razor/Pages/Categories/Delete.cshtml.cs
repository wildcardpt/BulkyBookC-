using BulkyBook_Razor.Data;
using BulkyBook_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyBook_Razor.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category category { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {

            if (id == null || id == 0)
                NotFound();

            category = _db.Categories.Find(id);
            if (category == null)
                NotFound();
        }

        public async Task<IActionResult> OnPost() {
            Category? obj = _db.Categories.Find(category.Id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            await _db.SaveChangesAsync();
            TempData["success"] = "Category deleted successfully!";
            return RedirectToPage("Index");
        }
    }
}
