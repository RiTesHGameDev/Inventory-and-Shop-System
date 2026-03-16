using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryController
{
    private PlayerInventoryModel playerInventoryModel;
    private PlayerInventoryView playerInventoryView;
    private CurrencyService currencyService;
    public PlayerInventoryController(PlayerInventoryView view, CurrencyService _currencyService)
    {
        playerInventoryModel = new PlayerInventoryModel();
        this.playerInventoryView = view;
        this.currencyService = _currencyService;

        playerInventoryView.Initialize(this,currencyService);
    }

    public bool CanAdd(ItemData item, int quantity)
    {
        float weight = item.weight * quantity;
        return playerInventoryModel.currentWeight + weight <= playerInventoryModel.maxWeight;
    }

    public void AddItem(ItemData item, int quantity)
    {
        InventoryItemModel existing = playerInventoryModel.playerItems.Find(i => i.data == item);

        if (existing != null)
        {
            existing.quantity += quantity;
        }
        else
        {
            playerInventoryModel.playerItems.Add(new InventoryItemModel(item, quantity, ItemSource.PlayerInventory));
        }

        playerInventoryModel.currentWeight += item.weight * quantity;
        playerInventoryView.RefreshInventory();
    }

    public void RemoveItem(ItemData item, int quantity)
    {
        InventoryItemModel existing = playerInventoryModel.playerItems.Find(i => i.data == item);

        if (existing == null)
            return;

        existing.quantity -= quantity;

        if (existing.quantity <= 0)
            playerInventoryModel.playerItems.Remove(existing);

        playerInventoryModel.currentWeight -= item.weight * quantity;
        playerInventoryView.RefreshInventory();
    }

    public void IncreaseCapacity(float amount)
    {
        playerInventoryModel.maxWeight += amount;
        playerInventoryView.RefreshInventory();
    }
    public float GetCurrentWeight()
    {
        return playerInventoryModel.currentWeight;
    }

    public float GetMaxWeight()
    {
        return playerInventoryModel.maxWeight;
    }
    public List<InventoryItemModel> getPlayerInventoryItems()
    {
        return playerInventoryModel.getPlayerItemList();
    }

}
