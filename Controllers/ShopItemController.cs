using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingList.Models;
using ShoppingList.Repositories;

namespace ShoppingList.Controllers
{
    public class ShopItemController : Controller
    {
        private readonly IShoppingListRepository _repository;

        public ShopItemController(IShoppingListRepository repository)
        {
            _repository = repository;
        }
        // GET: ShopItem
        public ActionResult Index()
        {
            return View(_repository.GetAll());
        }

        // GET: ShopItem/Details/5
        public ActionResult Details(int id)
        {
            return View(_repository.Get(id));
        }

        // GET: ShopItem/Create
        public ActionResult Create()
        {
            return View(new ShopItemModel());
        }

        // POST: ShopItem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ShopItemModel model)
        {
            _repository.Add(model);

            return RedirectToAction(nameof(Index));
        }

        // GET: ShopItem/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repository.Get(id));
        }

        // POST: ShopItem/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ShopItemModel model)
        {
            _repository.Update(id,model);

            return RedirectToAction(nameof(Index));
        }

        // GET: ShopItem/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repository.Get(id));
        }

        // POST: ShopItem/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ShopItemModel model)
        {
            _repository.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        //ShopItem/Taken/1
        public ActionResult Taken(int id)
        {
            ShopItemModel model = _repository.Get(id);
            model.Taken = true;
            _repository.Update(id, model);

            return RedirectToAction(nameof(Index));
        }
    }
}