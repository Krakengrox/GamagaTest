using UnityEngine;
using System.Collections.Generic;

public class ItemManager
{

    List<Transform> items = null;
    Item item = null;
    ItemData itemData;

    public ItemManager(List<Transform> items, ItemData itemData)
    {
        this.items = items;
        this.itemData = itemData;
        CreatedEnemies();
    }

    void CreatedEnemies()
    {
        for (int i = 0; i < items.Count; i++)
        {
            item = new Item(items[i].gameObject, this.itemData);
        }
    }

}


