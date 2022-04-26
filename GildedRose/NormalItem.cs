using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class NormalItem : BaseItem
    {
        public NormalItem(Item item) : base(item) 
        {
        }
        public override void Update()
        {
            DecreaseQuality();
            DecreaseSellIn();
            if (Item.SellIn < 0)
            {
                DecreaseQuality();
            }
        }
    }
}
