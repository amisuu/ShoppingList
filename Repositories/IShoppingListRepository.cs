using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Repositories
{
    public interface IShoppingListRepository
    {
        ShopItemModel Get(int id);
        IQueryable<ShopItemModel> GetAll();
        void Add(ShopItemModel model);
        void Update(int id, ShopItemModel model);
        void Delete(int id);


    }
}
