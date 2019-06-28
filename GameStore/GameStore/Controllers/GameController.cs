using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new GameStoreDbContext())
            {
                var allGame = db.Games.ToList();
                return View(allGame);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(string name, string dlc, double price, string platform)
        {
            Game game = new Game
            {
                Name = name,
                Dlc = dlc,
                Price = price,
                Platform = platform
            };

            using (var db = new GameStoreDbContext())
            {
                db.Games.Add(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var GameToEdit = db.Games.FirstOrDefault(t=>t.Id == id) ;   //db.Games.Find(id) - sushto moje das e 

                if (GameToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(GameToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameToEdit = db.Games.FirstOrDefault(t => t.Id == game.Id);

                gameToEdit.Name = game.Name;
                gameToEdit.Dlc = game.Dlc;
                gameToEdit.Price = game.Price;
                gameToEdit.Platform = game.Platform;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var GameToDelete = db.Games.FirstOrDefault(t => t.Id == id);   //db.Games.Find(id) - sushto moje das e 
                return this.View(GameToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameToDelete = db.Games.FirstOrDefault(t => t.Id == game.Id);

                db.Games.Remove(gameToDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}