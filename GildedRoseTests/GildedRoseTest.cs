using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {

        private static IList<Item> InitializeTest(string name , int sellIn , int quality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            return Items;
        }

        [Fact]
        public void GildedRose_NormalItemGiven_SellInQualityDecrease()
        {
            IList<Item> Items = InitializeTest("NormalItem" ,15 , 15);
            Assert.Equal("NormalItem", Items[0].Name);
            Assert.Equal(14, Items[0].SellIn);
            Assert.Equal(14, Items[0].Quality);
        }
        [Fact]
        public void GildedRose_NormalItemGivenSellinPassed_QualityDecrease2TimesFaster()
        {
            IList<Item> Items = InitializeTest("NormalItem", 0, 15);
            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(13, Items[0].Quality);
        }

        [Fact]
        public void GildedRose_NormalItemQuality0_QualityDoesNotChange()
        {
            IList<Item> Items = InitializeTest("NormalItem", 15, 0);
            Assert.Equal(14, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void GildedRose_ArgedBrie_QualityIncrease()
        {
            IList<Item> Items = InitializeTest("Aged Brie", 15, 15);
            Assert.Equal(14, Items[0].SellIn);
            Assert.Equal(16, Items[0].Quality);
        }

        [Fact]
        public void GildedRose_ArgedBrieSellinlessThanZero_QualityIncrease()
        {
            IList<Item> Items = InitializeTest("Aged Brie", -1, 15);
            Assert.Equal(-2, Items[0].SellIn);
            Assert.Equal(17, Items[0].Quality);
        }
        [Fact]
        public void GildedRose_NormalItemQualityIs50_QualityDoesNotChange()
        {
            IList<Item> Items = InitializeTest("Aged Brie", 15, 50);
            Assert.Equal(14, Items[0].SellIn);
            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        public void GildedRose_Sulfuras_QualitySellInNeverChanges()
        {
            IList<Item> Items = InitializeTest("Sulfuras, Hand of Ragnaros", 15, 15);
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

            IList<Item> Items = InitializeTest("Backstage passes to a TAFKAL80ETC concert", sellIn, quality);

            Assert.Equal(expectedSellIn, Items[0].SellIn);
            Assert.Equal(expectedQuality, Items[0].Quality);
        }
    }
}
