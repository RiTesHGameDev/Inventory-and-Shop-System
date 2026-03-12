using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ItemDescriptionView : MonoBehaviour
{
    public GameObject descriptionPanel;

    public Image icon;
    public TMP_Text nameText;
    public TMP_Text infoText;
    public TMP_Text buyPriceText;
    public TMP_Text sellPriceText;
    public TMP_Text weightText;
    public TMP_Text rarityText;

    public Button closeButton;

    private void Awake()
    {
        descriptionPanel.SetActive(false);
        EventService.Instance.OnItemSelection.AddListener(Show);
    }
    private void OnDestroy()
    {
        EventService.Instance.OnItemSelection.RemoveListener(Show);
    }

    private void Start()
    {
        closeButton.onClick.AddListener(OnCloseButtonClick);
    }
    private void Show(ItemData item)
    {
        descriptionPanel.SetActive(true);

        icon.sprite = item.icon;
        nameText.text = "Name : " + item.itemName;
        infoText.text = "Info : " + item.description;

        buyPriceText.text = "Buy: " + item.buyPrice;
        sellPriceText.text = "Sell: " + item.sellPrice;

        weightText.text = "Weight: " + item.weight;
        rarityText.text = "Rarity: " + item.rarity.ToString();
    }

    private void OnCloseButtonClick()
    {
        descriptionPanel.SetActive(false);
    }
}
