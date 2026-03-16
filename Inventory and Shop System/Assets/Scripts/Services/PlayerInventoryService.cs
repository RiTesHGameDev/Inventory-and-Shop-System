using UnityEngine;
public class PlayerInventoryService
{
    private PlayerInventoryController controller;

    public PlayerInventoryService(PlayerInventoryView view, CurrencyService currencyService)
    {
        controller = new PlayerInventoryController(view, currencyService);
    }

    public bool CanAdd(ItemData item, int quantity)
    {
        return controller.CanAdd(item, quantity);
    }

    public void AddItem(ItemData item, int quantity)
    {
        controller.AddItem(item, quantity);
    }

    public void RemoveItem(ItemData item, int quantity)
    {
        controller.RemoveItem(item, quantity);
    }

    public PlayerInventoryController GetController()
    {
        return controller;
    }
}
