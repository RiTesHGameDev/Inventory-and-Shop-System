public class InventoryItemModel
{
    public ItemData data;
    public int quantity;

    public float TotalWeight()
    {
        return data.weight * quantity; 
    }
}
