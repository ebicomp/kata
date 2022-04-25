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

        private bool isBrie(Item item)
        {
            return item.Name == Brie;
        }
        private bool isBackStage(Item item)
        {
            return item.Name == Backstage;
        }
        private bool isSulfuras(Item item)
        {
            return item.Name == Sulfuras;
        }
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
        public void UpdateQuality()
        {

            foreach (var item in Items)
            {
                if (!isBrie(item) && !isBackStage(item))
                {
                    if (!isSulfuras(item))
                    {
                        DecreaseQuality(item);
                    }
                }
                else
                {
                    if (item.Quality < MaxQuality)
                    {
                        IncreaseQuality(item);

                        if (isBackStage(item))
                        {
                            if (item.SellIn < 11)
                            {
                                IncreaseQuality(item);
                            }

                            if (item.SellIn < 6)
                            {
                                IncreaseQuality(item);
                            }
                        }
                    }
                }

                if (!isSulfuras(item))
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellIn < 0)
                {
                    if (!isBrie(item))
                    {
                        if (!isBackStage(item))
                        {
                            if (!isSulfuras(item))
                            {
                                DecreaseQuality(item);
                            }
                        }
                        else
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                    }
                    else
                    {
                        IncreaseQuality(item);
                    }
                }
            }
        }
    }
}
