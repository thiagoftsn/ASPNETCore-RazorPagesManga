using ASPNETCore_RazorPagesManga.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ASPNETCore_RazorPagesManga.Pages.Mangas
{
    public class IndexModel : PageModel
    {
        private readonly ASPNETCore_RazorPagesManga.Data.ASPNETCore_RazorPagesMangaContext _context;

        public IndexModel(ASPNETCore_RazorPagesManga.Data.ASPNETCore_RazorPagesMangaContext context)
        {
            _context = context;
        }

        public IList<Manga> Manga { get;set; }

        public async Task OnGetAsync()
        {
            Manga = await _context.Manga.ToListAsync();
        }
    }
}
