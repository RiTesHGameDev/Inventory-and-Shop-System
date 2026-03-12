using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotView : MonoBehaviour
{
    public Image icon;
    public TMPro.TextMeshProUGUI quantityText;

    ItemData itemData;

    public void SetUp(InventoryItemModel item)
    {
        itemData = item.data;

        icon.sprite = item.data.icon;
        quantityText.text = item.quantity.ToString();
    }

}
