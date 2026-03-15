using System.Collections.Generic;

public class ShopModel
{
    private ItemDataBase dataBase;

    private List<InventoryItemModel> shopItems = new List<InventoryItemModel>();
    public ShopModel(ItemDataBase data)
    {
        dataBase = data;

        foreach (ItemData item in dataBase.GetItems())
        {
            CreateItem(item);
        }
    }
    private void CreateItem(ItemData data)
    {
        InventoryItemModel itemModel = new InventoryItemModel(data, 1);
        shopItems.Add(itemModel);
    }
    public List<InventoryItemModel> GetShopItems()
    {
        return shopItems;
    }

}
