public class InventoryItemModel
{
    public ItemData data;
    public int quantity;

    public InventoryItemModel(ItemData data, int quantity)
    {
        this.data = data;
        this.quantity = quantity;
    }
}
