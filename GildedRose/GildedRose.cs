using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private const string Brie = "Aged Brie";
        private const string Backstage = "Backstage passes to a TAFKAL80ETC concert";
        private const string Sulfuras = "Sulfuras, Hand of Ragnaros";

        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }
       

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                var itemCalculator = new ItemCalculator(item);
                switch (item.Name)
                {
                    case Brie:
                        itemCalculator.UpdateBrie();
                        break;
                    case Backstage:
                        itemCalculator.UpdateBackStage();
                        break;
                    case Sulfuras:
                        break;
                    default:
                        itemCalculator.UpdateNormalItem();
                        break;
                }
            }
        }
    }
}
