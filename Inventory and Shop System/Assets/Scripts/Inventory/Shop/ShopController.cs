using System.Collections.Generic;
using UnityEngine.UIElements;

public class ShopController
{
    private ShopModel shopModel;
    private ShopView shopView;

    public ShopController(ItemDataBase dataBase, ShopView view)
    {
        shopModel = new ShopModel(dataBase);
        shopView = view;

        shopView.SetShopController(this);

        InitializeShop();
    }

    private void InitializeShop()
    {
        shopView.RefreshShop();
    }

    public List<InventoryItemModel> GetShopItems()
    {
        return shopModel.GetShopItems();
    }
}
