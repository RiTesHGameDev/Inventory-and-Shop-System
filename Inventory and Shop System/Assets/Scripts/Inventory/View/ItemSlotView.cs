using UnityEngine;
using UnityEngine.UI;

public class ItemSlotView : MonoBehaviour
{
    public Image icon;
    public TMPro.TextMeshProUGUI quantityText;

    private InventoryItemModel item;
    private Button itemButton;
    private void Awake()
    {
        itemButton = GetComponent<Button>();
        itemButton.onClick.AddListener(OnItemSelection);
    }
    public void SetUp(InventoryItemModel item)
    {
        this.item = item;

        icon.sprite = item.data.icon;
        quantityText.text = item.quantity.ToString();
    }
    private void OnItemSelection()
    {
        Debug.Log("Item Clicked: " + item.data);
        EventService.Instance.OnItemSelection.InvokeEvent(item);
    }
}
