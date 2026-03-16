using UnityEngine;

public class ShopService
{
    private ShopController shopController;
    private PlayerInventoryService playerInventoryService;
    private CurrencyService currencyService;

    public ShopService(ItemDatabase database,
                       ShopView shopView,
                       PlayerInventoryService _playerInventoryService,
                       CurrencyService currencyService)
    {
        this.playerInventoryService = _playerInventoryService;
        this.currencyService = currencyService;

        shopController = new ShopController(database, shopView, this);
    }

    public void BuyItem(ItemData item, int quantity)
    {
        int cost = item.buyPrice * quantity;

        if (!currencyService.CanSpend(cost))
        {
            Debug.Log("Not enough currency");
            return;
        }

        if (!playerInventoryService.CanAdd(item, quantity))
        {
            Debug.Log("Inventory Full");
            return;
        }

        currencyService.Remove(cost);
        playerInventoryService.AddItem(item, quantity);
    }

    public void SellItem(ItemData item, int quantity)
    {
        int value = item.sellPrice * quantity;

        currencyService.Add(value);
        playerInventoryService.RemoveItem(item, quantity);
    }
}
