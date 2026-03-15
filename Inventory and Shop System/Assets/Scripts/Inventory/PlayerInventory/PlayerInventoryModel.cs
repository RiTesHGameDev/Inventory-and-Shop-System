using System.Collections.Generic;

public class PlayerInventoryModel
{
    public int currency;
    public float maxWeight = 2000f;
    public float currentWeight;

    private List<InventoryItemModel> playerItems = new List<InventoryItemModel>();
    public PlayerInventoryModel() { }
    public bool CanAdd(ItemData item,int quantity)
    {
        float weight = item.weight * quantity;
        return currentWeight + weight <= maxWeight;
    }
    public void AddItem(ItemData item, int quantity)
    {
        InventoryItemModel existingItem = playerItems.Find(i => i.data == item);
        if (existingItem != null)
        {
            existingItem.quantity += quantity;
        }
        else
        {
            playerItems.Add(new InventoryItemModel(item,quantity));
        }

        currentWeight += item.weight * quantity;
    }

    public void RemoveItem(ItemData item, int quantity)
    {
        InventoryItemModel existingItem = playerItems.Find(i=> i.data == item);

        if (existingItem == null)
            return;

        existingItem.quantity -= quantity;

        if(existingItem.quantity <= 0)
        {
            playerItems.Remove(existingItem);
        }

        currentWeight -= item.weight * quantity;

    }
    public List<InventoryItemModel> getPlayerInventoryItemList()
    {
        return playerItems;
    }
}
