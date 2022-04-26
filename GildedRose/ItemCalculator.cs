using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    class ItemCalculator
    {
        private Item Item;
        public ItemCalculator(Item item)
        {
            this.Item = item;
        }

        private const int MinQuality = 0;
        private const int MaxQuality = 50;

        private void DecreaseQuality()
        {
            if (Item.Quality > MinQuality)
                Item.Quality -= 1;
        }
        private void IncreaseQuality()
        {
            if (Item.Quality < MaxQuality)
                Item.Quality += 1;
        }
        private void DecreaseSellIn()
        {
            Item.SellIn = Item.SellIn - 1;
        }
        public void UpdateBrie()
        {
            IncreaseQuality();
            DecreaseSellIn();
            if (Item.SellIn < 0)
            {
                IncreaseQuality();
            }
        }
        public void UpdateBackStage()
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
        public void UpdateNormalItem()
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
