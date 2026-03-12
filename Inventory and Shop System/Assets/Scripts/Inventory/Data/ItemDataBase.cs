using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventory/ItemDataBase")]
public class ItemDataBase : ScriptableObject
{
    public List<ItemData> items;

    public List<ItemData> GetItemsByType(ItemType type)
    {
        List<ItemData> result = new List<ItemData>();

        foreach (ItemData item in items)
        {
            if (item.type == type)
            {
                result.Add(item);
            }
        }
        return result;
    }

    public List<ItemData> GetItems()
    {
        return items;
    }
}
