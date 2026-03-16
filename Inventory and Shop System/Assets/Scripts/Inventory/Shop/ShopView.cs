using UnityEngine;

public class ShopView : MonoBehaviour
{
    private ShopController shopController;

    public Transform gridParent;
    public GameObject itemSlotPrefab;
    public ItemDescriptionView descriptionView;

    public void SetShopController(ShopController controller)
    {
        shopController = controller;
        descriptionView.Initialize(controller);
    }

    public void RefreshShop()
    {
        foreach (Transform child in gridParent)
        {
            Destroy(child.gameObject);
        }

        foreach (InventoryItemModel item in shopController.GetShopItems())
        {
            GameObject slot = Instantiate(itemSlotPrefab, gridParent);

            ItemSlotView view = slot.GetComponent<ItemSlotView>();
            view.SetUp(item);
        }
    }
}
