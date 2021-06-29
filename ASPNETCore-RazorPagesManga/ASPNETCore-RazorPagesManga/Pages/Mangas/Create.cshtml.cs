using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPNETCore_RazorPagesManga.Data;
using ASPNETCore_RazorPagesManga.Models;

namespace ASPNETCore_RazorPagesManga.Pages.Mangas
{
    public class CreateModel : PageModel
    {
        private readonly ASPNETCore_RazorPagesManga.Data.ASPNETCore_RazorPagesMangaContext _context;

        public CreateModel(ASPNETCore_RazorPagesManga.Data.ASPNETCore_RazorPagesMangaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Manga Manga { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Manga.Add(Manga);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
