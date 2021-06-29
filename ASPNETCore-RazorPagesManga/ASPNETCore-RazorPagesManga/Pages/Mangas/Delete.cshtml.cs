using ASPNETCore_RazorPagesManga.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ASPNETCore_RazorPagesManga.Pages.Mangas
{
    public class DeleteModel : PageModel
    {
        private readonly ASPNETCore_RazorPagesManga.Data.ASPNETCore_RazorPagesMangaContext _context;

        public DeleteModel(ASPNETCore_RazorPagesManga.Data.ASPNETCore_RazorPagesMangaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Manga Manga { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manga = await _context.Manga.FirstOrDefaultAsync(m => m.ID == id);

            if (Manga == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manga = await _context.Manga.FindAsync(id);

            if (Manga != null)
            {
                _context.Manga.Remove(Manga);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
