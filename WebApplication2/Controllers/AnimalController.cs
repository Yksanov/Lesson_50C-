using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers;

public class AnimalController : Controller
{
    private readonly ZooStoreContext _context;

    public AnimalController(ZooStoreContext context)
    {
        _context = context;
    }
    
    // GET
    public IActionResult Index()
    {
        List<Animal> animals = _context.Animals.ToList();
        return View(animals);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Animal animal)
    {
        if (animal != null)
        {
            _context.Add(animal);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View(animal);
    }
}