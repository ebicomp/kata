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
        public void UpdateQuality()
        {

            foreach (var item in Items)
            {
                if (!isBrie(item) && item.Name != Backstage)
                {
                    if (item.Quality > MinQuality)
                    {
                        if (item.Name != Sulfuras)
                        {
                            item.Quality = item.Quality - 1;
                        }
                    }
                }
                else
                {
                    if (item.Quality < MaxQuality)
                    {
                        item.Quality = item.Quality + 1;

                        if (item.Name == Backstage)
                        {
                            if (item.SellIn < 11)
                            {
                                if (item.Quality < MaxQuality)
                                {
                                    item.Quality = item.Quality + 1;
                                }
                            }

                            if (item.SellIn < 6)
                            {
                                if (item.Quality < MaxQuality)
                                {
                                    item.Quality = item.Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (item.Name != Sulfuras)
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellIn < 0)
                {
                    if (!isBrie(item))
                    {
                        if (item.Name != Backstage)
                        {
                            if (item.Quality > MinQuality)
                            {
                                if (item.Name != Sulfuras)
                                {
                                    item.Quality = item.Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                    }
                    else
                    {
                        if (item.Quality < MaxQuality)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
