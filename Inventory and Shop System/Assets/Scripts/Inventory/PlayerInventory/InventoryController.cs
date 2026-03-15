using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryController
{
    private PlayerInventoryModel playerInventoryModel;
    private PlayerInventoryView inventoryView;
    public PlayerInventoryController(PlayerInventoryView view)
    {
        playerInventoryModel = new PlayerInventoryModel();
        inventoryView = view;

        inventoryView.SetInventoryController(this);
    }

    public void AddItem(ItemData item, int quantity)
    {
        if (playerInventoryModel.CanAdd(item, quantity))
        {
            playerInventoryModel.AddItem(item, quantity);

            inventoryView.RefreshInventory();
        }
        else
        {
            Debug.Log("Inventory weight exceeded!");
        }
    }

    public void RemoveItem(ItemData item, int quantity)
    {
        playerInventoryModel.RemoveItem(item, quantity);

        inventoryView.RefreshInventory();
    }

    public List<InventoryItemModel> GetPlayerInventoryItems()
    {
        return playerInventoryModel.getPlayerInventoryItemList();
    }

}
