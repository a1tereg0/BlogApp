using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BlogApp.Context;
using BlogApp.Models;

namespace BlogApp.Pages.Admin.AuthorPages
{
    public class DetailsModel : PageModel
    {
        private readonly BlogApp.Context.DataContext _context;

        public DetailsModel(BlogApp.Context.DataContext context)
        {
            _context = context;
        }

        public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Author = await _context.Authors.FirstOrDefaultAsync(m => m.AuthorID == id);

            if (Author == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
