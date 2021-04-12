using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BlogApp.Models;

namespace BlogApp.Pages
{
    public class BlogPostModel : PageModel
    {
        private readonly BlogApp.Context.DataContext _context;

        public Blog Blog { get; set; }
        public BlogPostModel(BlogApp.Context.DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Blog = await _context.Blogs.Include(b => b.Author).FirstOrDefaultAsync(b => b.BlogID == id);

            if (Blog == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
