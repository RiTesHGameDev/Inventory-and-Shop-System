using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public ItemDataBase dataBase;
    public Transform gridParent;
    public GameObject itemSlotPrefab;

    void Start()
    {
        foreach(ItemData item in dataBase.GetItems())
        {
            CreateItem(item);
        }
    }
    public void CreateItem(ItemData data)
    {
        GameObject slot = Instantiate(itemSlotPrefab, gridParent);

        InventoryItemModel itemModel = new InventoryItemModel(data, 1);
        itemModel.data = data;
        itemModel.quantity = 1;

        ItemSlotView slotView = slot.GetComponent<ItemSlotView>();
        slotView.SetUp(itemModel);
    }
}
