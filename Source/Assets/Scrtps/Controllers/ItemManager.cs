using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Associated all item GameObject in the level with an instance of one item class
/// </summary>
public class ItemManager
{
    #region variables

    /// <summary>
    /// Items List in the level
    /// </summary>
    List<Transform> items = null;

    /// <summary>
    /// Item instance
    /// </summary>
    Item item = null;

    /// <summary>
    /// Item Data
    /// </summary>
    ItemData itemData;

    #endregion
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="items"></param>
    /// <param name="itemData"></param>
    public ItemManager(List<Transform> items, ItemData itemData)
    {
        this.items = items;
        this.itemData = itemData;
        CreatedItems();
    }

    /// <summary>
    ///  Create all Items
    /// </summary>
    void CreatedItems()
    {
        for (int i = 0; i < items.Count; i++)
        {
            item = new Item(items[i].gameObject, this.itemData);
        }
    }

}


