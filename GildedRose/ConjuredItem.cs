using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class ConjuredItem : BaseItem
    {
        public ConjuredItem(Item item) : base(item) 
        {
        }
        public override void Update()
        {
            DecreaseQuality();
            DecreaseQuality();
            DecreaseSellIn();
            if (Item.SellIn < 0)
            {
                DecreaseQuality();
            }
        }
    }
}
