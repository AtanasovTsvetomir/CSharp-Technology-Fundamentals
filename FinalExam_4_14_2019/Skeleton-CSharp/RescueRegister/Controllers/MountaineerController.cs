using RescueRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RescueRegister.Controllers
{
    public class MountaineerController : Controller
    {
        private readonly RescueRegisterDbContext context;

        public MountaineerController(RescueRegisterDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            using (var db = new RescueRegisterDbContext())
            {
                var allRegister = db.Mountaineers.ToList();
                return View(allRegister);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Mountaineer mountaineer)
        {
            using (var db = new RescueRegisterDbContext())
            {
                db.Mountaineers.Add(mountaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new RescueRegisterDbContext())
            {
                var registerToEdit = db.Mountaineers.Find(id);

                if (registerToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(registerToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Mountaineer mountaineer)
        {
            using (var db = new RescueRegisterDbContext())
            {
                db.Mountaineers.Update(mountaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new RescueRegisterDbContext())
            {
                var RegisterToDelete = db.Mountaineers.Find(id);

                if (RegisterToDelete == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(RegisterToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Mountaineer mountaineer)
        {
            using (var db = new RescueRegisterDbContext())
            {
                db.Mountaineers.Remove(mountaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}