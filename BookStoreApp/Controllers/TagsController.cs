using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStoreApp.Models;
using System;
using System.Threading.Tasks;
using BookStoreApp.Data;

namespace BookStoreApp.Controllers
{
    public class TagsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TagsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var tag = _context.Tags.ToList();
            return View(tag);
        }

        // GET: Tags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tags/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddTagRequest tag)
        {
            if (ModelState.IsValid)
            {
                _context.Tags.Add(new Tag { Name = tag.Name });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(tag);
        }

        // GET: Tags/Edit/{id}
        public async Task<IActionResult> Edit(Guid id)
        {
            var tag = await _context.Tags.FindAsync(id);
            if (tag == null)
            {
                return NotFound();
            }
            return View(tag);
        }

        // POST: Tags/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditTagRequest tag)
        {

            if (ModelState.IsValid)
            {
                _context.Tags.Find(tag.Id).Name = tag.Name;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(tag);
        }

        // GET: Tags/Details/{id}
        public async Task<IActionResult> Details(Guid id)
        {
            var tag = await _context.Tags.FindAsync(id);
            if (tag == null)
            {
                return NotFound();
            }
            return View(tag);
        }

        // GET: Tags/Delete/{id}
        public async Task<IActionResult> Delete(Guid id)
        {
            var tag = await _context.Tags.FindAsync(id);
            if (tag == null)
            {
                return NotFound();
            }
            return View(tag);
        }

        // POST: Tags/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tag = await _context.Tags.FindAsync(id);
            if (tag == null)
            {
                return NotFound();
            }

            _context.Tags.Remove(tag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TagExists(Guid id)
        {
            return _context.Tags.Any(e => e.Id == id);
        }
    }
}
