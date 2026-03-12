using UnityEngine;
using UnityEngine.UI;

public class ItemSlotView : MonoBehaviour
{
    public Image icon;
    public TMPro.TextMeshProUGUI quantityText;

    private ItemData itemData;
    private Button itemButton;
    private void Awake()
    {
        itemButton = GetComponent<Button>();
        itemButton.onClick.AddListener(OnItemSelection);
    }
    public void SetUp(InventoryItemModel item)
    {
        itemData = item.data;

        icon.sprite = item.data.icon;
        quantityText.text = item.quantity.ToString();
    }
    private void OnItemSelection()
    {
        Debug.Log("Item Clicked: " + itemData.itemName);
        EventService.Instance.OnItemSelection.InvokeEvent(itemData);
    }
}
