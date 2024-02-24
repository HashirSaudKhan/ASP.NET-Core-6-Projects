using CrudCFASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CrudCFASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentDbContext studentDb;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(StudentDbContext studentDb)
        {
            this.studentDb = studentDb;
        }

        public async Task<IActionResult> Index()
        {
            var stdData = await studentDb.Students.ToListAsync();
            return View(stdData);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student std)
        {
            if (ModelState.IsValid)
            {
               await  studentDb.Students.AddAsync(std);
               await studentDb.SaveChangesAsync();
                TempData["inserted_success"] = "Inserted..";
                return RedirectToAction("Index", "Home"); 
            }
            return View(std);
            }
        public async Task<IActionResult> Details(int? id)
        {
            if (ModelState == null || studentDb.Students == null)
            {
                return NotFound();
            }
            var stddata = await studentDb.Students.FirstOrDefaultAsync(x => x.Id == id);
              if(stddata ==  null)
              {
                  return NotFound();
              }
            return View(stddata);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (ModelState == null || studentDb.Students == null)
            {
                return NotFound();
            }
            var stddata = await studentDb.Students.FindAsync(id);
            if (stddata == null)
            {
                return NotFound();
            }
            return View(stddata);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int? id,Student std)
        {
            if(id != std.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                studentDb.Update(std);
                await studentDb.SaveChangesAsync();
                TempData["Edited_success"] = "Edited..";
                return RedirectToAction("Index", "Home");
            }
            return View(std);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if( id == null || studentDb.Students == null)
            {
                return NotFound();
            }
            var stddata = await studentDb.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (stddata == null)
            {
                return NotFound();
            }
            return View(stddata);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var stddata = await studentDb.Students.FindAsync(id);

            if (stddata != null)
            {
               studentDb.Students.Remove(stddata);

            }
            await studentDb.SaveChangesAsync();
            TempData["Deleted_success"] = "Deleted..";
            return RedirectToAction("Index","Home");
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
