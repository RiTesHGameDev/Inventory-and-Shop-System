using System.Collections.Generic;

public class ShopModel
{
    public List<InventoryItemModel> shopItems;
    public ShopModel() 
    {
        shopItems = new List<InventoryItemModel>();
    }
    public List<InventoryItemModel> GetShopItems()
    {
        return shopItems;
    }

}
