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
    public Button buyButton;
    public Button sellButton;

    private InventoryItemModel currentItem;
    private ShopController shopController;
    private void Awake()
    {
        descriptionPanel.SetActive(false);
        EventService.Instance.OnItemSelection.AddListener(Show);
    }
    private void Start()
    {
        buyButton.onClick.AddListener(OnBuyButtonClick);
        sellButton.onClick.AddListener(OnSellButtonClick);
        closeButton.onClick.AddListener(OnCloseButtonClick);
    }

    public void Initialize(ShopController _shopController)
    {
        shopController = _shopController;
    }
    private void Show(InventoryItemModel item)
    {
        currentItem = item;

        descriptionPanel.SetActive(true);

        icon.sprite = item.data.icon;
        nameText.text = "Name : " + item.data.itemName;
        infoText.text = "Info : " + item.data.description;

        buyPriceText.text = "Buy: " + item.data.buyPrice;
        sellPriceText.text = "Sell: " + item.data.sellPrice;

        weightText.text = "Weight: " + item.data.weight;
        rarityText.text = "Rarity: " + item.data.rarity.ToString();

        if (item.source == ItemSource.Shop)
        {
            buyButton.gameObject.SetActive(true);
            sellButton.gameObject.SetActive(false);
        }
        else
        {
            buyButton.gameObject.SetActive(false);
            sellButton.gameObject.SetActive(true);
        }
    }

    private void OnCloseButtonClick()
    {
        descriptionPanel.SetActive(false);
    }
    private void OnBuyButtonClick()
    {
        if (currentItem == null)
            return;

        shopController.BuyItem(currentItem.data,1);
    }

    private void OnSellButtonClick()
    {
        if (currentItem == null)
            return;

        shopController.SellItem(currentItem.data, 1);
    }
}
