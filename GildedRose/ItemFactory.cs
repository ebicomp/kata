using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
   
    public class ItemFactory
    {
        private const string Brie = "Aged Brie";
        private const string Backstage = "Backstage passes to a TAFKAL80ETC concert";
        private const string Sulfuras = "Sulfuras, Hand of Ragnaros";


        private Item Item;
        public ItemFactory(Item item)
        {
            this.Item = item;
        }
        public BaseItem GetItemClass()
        {
            switch (Item.Name)
            {
                case Brie:
                    return new BrieItem(Item);
                case Backstage:
                    return new BackStageItem(Item);
                case Sulfuras:
                    return new BaseItem(Item);
                default:
                    return new NormalItem(Item);
            }
        }
    }
}
