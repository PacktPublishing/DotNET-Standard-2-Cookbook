using System;
using System.Collections.Generic;
using System.Collections;

namespace Chapter2.Collections.CollectionsLib
{
    public class LittleShop
    {
        public List<string> GetFruitsList()
        {
            var fruitsList = new List<string>();

            fruitsList.Add("Apples");
            fruitsList.Add("Grapes");
            fruitsList.Add("Mangoes");
            fruitsList.Add("Oranges");
            fruitsList.Add("Pineapples");

            return fruitsList;
        }

        public ArrayList GetShopItems()
        {
            var shopItems = new ArrayList();

            shopItems.Add("Fruits");
            shopItems.Add("Vegetables");
            shopItems.Add("Chocolates");

            return shopItems;
        }
    }
}
