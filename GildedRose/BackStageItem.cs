using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class BackStageItem : BaseItem
    {
        public BackStageItem(Item item) : base(item) 
        {
        }
        public override void Update()
        {
            IncreaseQuality();
            if (Item.SellIn < 11)
            {
                IncreaseQuality();
            }
            if (Item.SellIn < 6)
            {
                IncreaseQuality();
            }
            DecreaseSellIn();
            if (Item.SellIn < 0)
            {
                Item.Quality = 0;
            }
        }
    }
}
