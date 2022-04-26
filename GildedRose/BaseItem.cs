using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class BaseItem
    {
        protected Item Item;
        public BaseItem(Item item)
        {
            this.Item = item;
        }

        private const int MinQuality = 0;
        private const int MaxQuality = 50;

        protected void DecreaseQuality()
        {
            if (Item.Quality > MinQuality)
                Item.Quality -= 1;
        }
        protected void IncreaseQuality()
        {
            if (Item.Quality < MaxQuality)
                Item.Quality += 1;
        }
        protected void DecreaseSellIn()
        {
            Item.SellIn = Item.SellIn - 1;
        }
        public virtual void Update()
        {
            
        }
    }
}
