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

        private bool isNormalItem(Item item)
        {
            return !isBrie(item) && !isBackStage(item) && !isSulfuras(item);
        }
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
        private void DecreaseSellIn(Item item)
        {
            item.SellIn = item.SellIn - 1;
        }

        public void UpdateQuality()
        {

            foreach (var item in Items)
            {

                if (isBrie(item))
                {
                    IncreaseQuality(item);
                    DecreaseSellIn(item);
                    if (item.SellIn < 0)
                    {
                        IncreaseQuality(item);
                    }
                }
                else if (isBackStage(item))
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
                else if (isSulfuras(item))
                { 
                }
                else if (isNormalItem(item))
                {
                    DecreaseQuality(item);
                    DecreaseSellIn(item);
                }

                //if (!isSulfuras(item))
                //{
                //    DecreaseSellIn(item);
                //}

                if (item.SellIn < 0)
                {
                    if (!isBrie(item) && !isBackStage(item) && !isSulfuras(item))
                    {
                        DecreaseQuality(item);
                    }
                }
            }
        }
    }
}
