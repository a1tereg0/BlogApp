using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BlogApp.Context;
using BlogApp.Models;

namespace BlogApp.Pages.Admin.BlogPages
{
    public class DetailsModel : PageModel
    {
        private readonly BlogApp.Context.DataContext _context;

        public DetailsModel(BlogApp.Context.DataContext context)
        {
            _context = context;
        }

        public Blog Blog { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog = await _context.Blogs
                .Include(b => b.Author).FirstOrDefaultAsync(m => m.BlogID == id);

            if (Blog == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
