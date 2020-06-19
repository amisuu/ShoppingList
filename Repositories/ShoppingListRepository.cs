using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ShoppingList.Repositories
{
    public class ShoppingListRepository : IShoppingListRepository
    {
        private readonly ShopListDbContext _context;

        public ShoppingListRepository(ShopListDbContext context)
        {
            _context = context;
        }

        public ShopItemModel Get(int id)
            => _context.ShopItemList.SingleOrDefault(y => y.ID == id);

        public IQueryable<ShopItemModel> GetAll()
            => _context.ShopItemList.Where(y => !y.Taken);

        public void Add(ShopItemModel model)
        {
            _context.ShopItemList.Add(model);
            _context.SaveChanges();
        }
        public void Update(int id, ShopItemModel model)
        {
            var result = _context.ShopItemList.SingleOrDefault(y => y.ID == id);
            if (result != null)
            {
                result.Name = model.Name;
                result.Description = model.Description;
                result.Section = model.Section;
                result.Taken = model.Taken;
                _context.SaveChanges();
            }        
        }
        public void Delete(int id)
        {
            var result = _context.ShopItemList.SingleOrDefault(y => y.ID == id);
            if (result != null)
            {
                _context.ShopItemList.Remove(result);
                _context.SaveChanges();
            }
        }
    }
}
