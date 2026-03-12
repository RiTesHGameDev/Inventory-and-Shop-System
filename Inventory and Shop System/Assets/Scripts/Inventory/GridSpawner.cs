using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    public ItemDataBase dataBase;
    public Transform gridParent;
    public GameObject itemSlotPrefab;

    void Start()
    {
        foreach(ItemData item in dataBase.GetItems())
        {
            CreateItem(item);
        }
    }
    public void CreateItem(ItemData data)
    {
        GameObject slot = Instantiate(itemSlotPrefab, gridParent);

        InventoryItemModel itemModel = new InventoryItemModel();
        itemModel.data = data;
        itemModel.quantity = 1;

        ItemSlotView slotView = slot.GetComponent<ItemSlotView>();
        slotView.SetUp(itemModel);
    }
}
