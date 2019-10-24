using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert" && Items[i].Name != "Sulfuras, Hand of Ragnaros" && Items[i].Quality > 0) //logikos salygas galima surasyti vienoje eiluteje, o ne viena po kitos
                {
                    Items[i].Quality = Items[i].Quality - 1;
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert" && Items[i].SellIn < 11) //pradine salyga "else" dalyje yra "prekes kokybe < 50
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                        else if (Items[i].SellIn < 6)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }
                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert" && Items[i].Name != "Sulfuras, Hand of Ragnaros" && Items[i].Name != "Sulfuras, Hand of Ragnaros" && Items[i].Quality > 0)
                    {
                        Items[i].Quality = Items[i].Quality - 1;
                    }
                    else if (Items[i].Quality < 50) // "else" atveju logikos salyga gali buti rasoma toje pacioje eiluteje
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                    if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")//koncerto bilietai turetu savo visa verte prarasti paskiausiai, po visu kokybes padidejimu
                    {
                        Items[i].Quality = Items[i].Quality - Items[i].Quality;
                    }
                }
            }
        }
    }
}