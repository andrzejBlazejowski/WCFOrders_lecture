using System.Linq;
using System.Collections.Generic;
using WCFOrders.Model.Entities;

namespace WCFOrders
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in both code and config file together.
    public class OrderService : IOrderService
    {
        public List<ItemForView> GetItems()
        {
            var db = new OrderEntities();
            var query = from item in db.Item select item;

            return query.ToList()
            .Select(item => new ItemForView(item))
            .ToList();
        }

        public List<ItemForView> GetItemSortByName()
        {
            var db = new OrderEntities();
            var query = from item in db.Item select item;
            query = query.OrderBy(item => item.Name);

            return query.ToList()
            .Select(item => new ItemForView(item))
            .ToList();
        }

    }
}
