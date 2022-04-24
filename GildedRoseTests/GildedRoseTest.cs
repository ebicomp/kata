using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }

        [Fact]
        public void GildedRose_NormalItemGiven_SellInQualityDecrease()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "NormalItem", SellIn = 15, Quality = 15 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("NormalItem", Items[0].Name);
            Assert.Equal(14, Items[0].SellIn);
            Assert.Equal(14, Items[0].Quality);
        }

        [Fact]
        public void GildedRose_NormalItemGivenSellinPassed_QualityDecrease2TimesFaster()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "NormalItem", SellIn = 0, Quality = 15 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(13, Items[0].Quality);
        }

        [Fact]
        public void GildedRose_NormalItemQuality0_QualityDoesNotChange()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "NormalItem", SellIn = 15, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(14, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void GildedRose_ArgedBrie_QualityIncrease()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 15, Quality = 15 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(14, Items[0].SellIn);
            Assert.Equal(16, Items[0].Quality);
        }
        [Fact]
        public void GildedRose_NormalItemQualityIs50_QualityDoesNotChange()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 15, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(14, Items[0].SellIn);
            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        public void GildedRose_Sulfuras_QualitySellInNeverChanges()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 15, Quality = 15 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(15, Items[0].SellIn);
            Assert.Equal(15, Items[0].Quality);
        }

        [Theory]
        [InlineData(15, 15, 14, 16)]
        [InlineData(10, 15, 9, 17)]
        [InlineData(5, 15, 4, 18)]
        [InlineData(1, 15, 0, 18)]
        [InlineData(0, 15, -1, 0)]
        public void GildedRose_Backstage_ChackRages(int sellIn , int quality, int expectedSellIn , int expectedQuality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(expectedSellIn, Items[0].SellIn);
            Assert.Equal(expectedQuality, Items[0].Quality);
        }
    }
}
