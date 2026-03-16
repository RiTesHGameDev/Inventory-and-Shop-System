public class InventoryItemModel
{
    public ItemData data;
    public int quantity;
    public ItemSource source;

    public InventoryItemModel(ItemData data, int quantity, ItemSource source)
    {
        this.data = data;
        this.quantity = quantity;
        this.source = source;
    }
}
