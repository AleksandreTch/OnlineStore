using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Basket
    {
        public int Id{get; set;}
        public string BuyerId{get; set;}
        public List<BasketItem>Items{get; set;} = new List<BasketItem>();

        public void AddItem(Product product, int quanitiy)
        {
            if(Items.All(item => item.ProductId != product.Id))
            {
                Items.Add(new BasketItem{Product = product, Quanitiy = quanitiy});
            }

            var existingItem = Items.FirstOrDefault(item => item.ProductId == product.Id);
            if(existingItem != null) existingItem.Quanitiy += quanitiy;
        }

        public void RemoveItem(int productId, int quantity)
        {
            var item = Items.FirstOrDefault(item => item.ProductId == productId);
            if(item == null) return;
            item.Quanitiy -= quantity;
            if(item.Quanitiy == 0) Items.Remove(item);
        }
    }
}