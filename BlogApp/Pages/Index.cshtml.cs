using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BlogApp.Models;
using Microsoft.EntityFrameworkCore;
using BlogApp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BlogApp.Context.DataContext _context;

        public IList<Blog> Blog { get; set; }

        public IndexModel(ILogger<IndexModel> logger, BlogApp.Context.DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Blog = await _context.Blogs.OrderByDescending(b => b.PublishDate).Take(5)
                .Include(b => b.Author).ToListAsync();
        }
    }
}
