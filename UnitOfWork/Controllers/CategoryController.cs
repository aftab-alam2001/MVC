using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Infrastructure.Implementation;
using Repository.Infrastructure.Interfaces;

namespace UnitOfWork.Controllers
{
    public class CategoryController : Controller
    {
        private IUnitOfWorks _unitOfWorks;

        public CategoryController(IUnitOfWorks unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
        }

        public IActionResult Index()
        {
            var categories = _unitOfWorks.Category.GetAll();
            return View(categories);
        }
        public IActionResult Create()
        {
            Category category = new Category();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if(ModelState.IsValid)
            {
                //Test for git branch
                _unitOfWorks.Category.Add(category);
                _unitOfWorks.SaveChanges();

                TempData["Success"] = "Category added succussfuly.";
                return RedirectToAction("Index");
            }
            return View(category);
        }
    }
}
