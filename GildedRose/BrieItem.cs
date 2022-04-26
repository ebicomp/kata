using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class BrieItem : BaseItem
    {
        public BrieItem(Item item) : base(item) 
        {
        }
        public override void Update()
        {
            IncreaseQuality();
            DecreaseSellIn();
            if (Item.SellIn < 0)
            {
                IncreaseQuality();
            }
        }
    }
}
