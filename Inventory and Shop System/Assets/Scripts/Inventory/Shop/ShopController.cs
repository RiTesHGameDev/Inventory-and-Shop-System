using System.Collections.Generic;

public class ShopController
{
    private ShopModel shopModel;
    private ShopView shopView;
    private ShopService shopService;

    public ShopController(ItemDatabase database, ShopView _shopView,ShopService _shopService)
    {
        shopModel = new ShopModel();
        this.shopView = _shopView;
        this.shopService = _shopService;

        shopView.SetShopController(this);

        foreach (var item in database.items)
        {
           shopModel.shopItems.Add(new InventoryItemModel(item, 1));
        }

        shopView.RefreshShop();
    }
    public List<InventoryItemModel> GetShopItems()
    {
        return shopModel.GetShopItems();
    }

    public void BuyItem(ItemData item, int quantity)
    {
        shopService.BuyItem(item, 1);
    }

    public void SellItem(ItemData item, int quantity)
    {
        shopService.SellItem(item, 1);
    }
}
