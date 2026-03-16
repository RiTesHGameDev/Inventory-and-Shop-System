using System.Collections.Generic;

public class PlayerInventoryModel
{
    public float maxWeight = 0f;
    public float currentWeight = 0f;

    public List<InventoryItemModel> playerItems;
    public PlayerInventoryModel() 
    {
        playerItems = new List<InventoryItemModel>();
    }
    public List<InventoryItemModel> getPlayerItemList()
    {
        return playerItems;
    }
}
