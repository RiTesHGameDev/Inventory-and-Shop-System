using UnityEngine;

public class PlayerInventoryView : MonoBehaviour
{
    public Transform gridParent;
    public GameObject itemSlotPrefab;

    private PlayerInventoryController playerInventoryController;

    private void Awake()
    {
        playerInventoryController = new PlayerInventoryController(this);
    }
    public void RefreshInventory()
    {
        foreach(Transform child in gridParent)
        {
            Destroy(child.gameObject);
        }
        foreach (InventoryItemModel item in playerInventoryController.GetPlayerInventoryItems())
        {
            GameObject slot = Instantiate(itemSlotPrefab,gridParent);

            ItemSlotView view = slot.GetComponent<ItemSlotView>();
            view.SetUp(item);
        }

    }
    public void SetInventoryController(PlayerInventoryController controller)
    {
        playerInventoryController = controller;
    }
}
