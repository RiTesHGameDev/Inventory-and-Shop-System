using System.Collections.Generic;

public class PlayerInventoryModel
{
    public float maxWeight;
    public float currentWeight;

    public List<InventoryItemModel> playerItems;
    public PlayerInventoryModel() 
    {
        maxWeight = 2000f;
        currentWeight = 0f;
        playerItems = new List<InventoryItemModel>();
    }
    public List<InventoryItemModel> getPlayerItemList()
    {
        return playerItems;
    }
}
