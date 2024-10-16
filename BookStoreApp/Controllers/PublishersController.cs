using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStoreApp.Models;
using System.Threading.Tasks;
using BookStoreApp.Data;

namespace BookStoreApp.Controllers
{
    public class PublishersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PublishersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Publishers.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddPublisherRequest apr)
        {
            if (ModelState.IsValid)
            {
                _context.Publishers.Add(new Publisher { Name = apr.Name });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(Index);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher == null)
            {
                return NotFound();
            }
            return View(publisher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditPublisherRequest epr)
        {

            if (ModelState.IsValid)
            {
                _context.Publishers.Find(epr.Id).Name = epr.Name;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Index);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher == null)
            {
                return NotFound();
            }
            return View(publisher);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher == null)
            {
                return NotFound();
            }
            return View(publisher);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            _context.Publishers.Remove(publisher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
