using Microsoft.AspNetCore.Mvc;
using P230_Pronia.Entities;
using System.Reflection.Metadata;

namespace P230_Pronia.Controllers
{
    public class BlogControllers : Controller
    {
        readonly ApplicationDbContext _context;

        public BlogControllers(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.Include(b => b.Category).ToList();
            return View(blogs);
        }
        public IActionResult Detail(int id)
        {
            if (id == 0) return NotFound();
            Blog? blog = _context.Blogs.Include(b => b.Category)
                                            .Include(b => b.BlogTags).ThenInclude(bt => bt.Tag)
                                                .SingleOrDefault(b => b.Id == id);

            return View(blog);
        }
    }
}
