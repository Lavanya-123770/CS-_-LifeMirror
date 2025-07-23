using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LifeMirror.Models;
using LifeMirror.Data;

namespace LifeMirror.Pages
{
    public class DataEntryFormModel : PageModel
    {
        private readonly AppDbContext _context;

        public DataEntryFormModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DataEntry DataEntry { get; set; }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.DataEntries.Add(DataEntry);
            await _context.SaveChangesAsync();
            return RedirectToPage("Success");
        }
    }
}
