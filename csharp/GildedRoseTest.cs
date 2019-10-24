using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreNotEqual("fixme", Items[0].Name); // turi buti nevienodi
        }
        [Test]
        public void foo1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Conjured Mana Cake", Items[0].Name); // privalo buti vienodi
            Assert.AreEqual(2, Items[0].SellIn); // privalo buti vienu maziau nei pradine
            Assert.AreEqual(5, Items[0].Quality); // privalo buti vienu maziau nei pradine
        }
    }
}
