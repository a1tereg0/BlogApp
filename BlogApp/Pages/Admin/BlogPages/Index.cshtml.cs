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
    public class IndexModel : PageModel
    {
        private readonly BlogApp.Context.DataContext _context;

        public IndexModel(BlogApp.Context.DataContext context)
        {
            _context = context;
        }

        public IList<Blog> Blog { get;set; }

        public async Task OnGetAsync()
        {
            Blog = await _context.Blogs
                .Include(b => b.Author).ToListAsync();
        }
    }
}
