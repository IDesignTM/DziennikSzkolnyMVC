using DziennikSzkolnyMVC.Data;
using DziennikSzkolnyMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DziennikSzkolnyMVC.Controllers;

public class SchoolClassesController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public SchoolClassesController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IActionResult> Index()
    {
        return View(await _context.SchoolClasses.ToListAsync());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,SchoolYear")] SchoolClass schoolClass)
    {
        if (ModelState.IsValid)
        {
            _context.Add(schoolClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));  
        }
        
        return View(schoolClass);
    }
}