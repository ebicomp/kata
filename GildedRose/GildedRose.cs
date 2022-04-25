using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }
        private const string Brie = "Aged Brie";
        private const string Backstage = "Backstage passes to a TAFKAL80ETC concert";
        private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        private const int MinQuality = 0;
        private const int MaxQuality = 50;

        private void DecreaseQuality(Item item)
        {
            if(item.Quality > MinQuality)
                item.Quality -= 1;
        }
        private void IncreaseQuality(Item item)
        {
            if (item.Quality < MaxQuality)
                item.Quality += 1;
        }
        private void DecreaseSellIn(Item item)
        {
            item.SellIn = item.SellIn - 1;
        }
        private void UpdateBrie(Item item)
        {
            IncreaseQuality(item);
            DecreaseSellIn(item);
            if (item.SellIn < 0)
            {
                IncreaseQuality(item);
            }
        }
        private void UpdateBackStage(Item item)
        {
            IncreaseQuality(item);
            if (item.SellIn < 11)
            {
                IncreaseQuality(item);
            }
            if (item.SellIn < 6)
            {
                IncreaseQuality(item);
            }
            DecreaseSellIn(item);
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
        private void UpdateNormalItem(Item item)
        {
            DecreaseQuality(item);
            DecreaseSellIn(item);
            if (item.SellIn < 0)
            {
                DecreaseQuality(item);
            }
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                switch (item.Name)
                {
                    case Brie:
                        UpdateBrie(item);
                        break;
                    case Backstage:
                        UpdateBackStage(item);
                        break;
                    case Sulfuras:
                        break;
                    default:
                        UpdateNormalItem(item);
                        break;
                }
            }
        }
    }
}
