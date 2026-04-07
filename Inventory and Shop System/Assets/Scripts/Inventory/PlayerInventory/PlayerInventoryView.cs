using TMPro;
using UnityEngine;

public class PlayerInventoryView : MonoBehaviour
{
    public Transform gridParent;
    public GameObject itemSlotPrefab;
    public TMP_Text weightText;
    public TMP_Text currencyText;

    private PlayerInventoryController playerInventoryController;
    private CurrencyService currencyService;

    private void Awake()
    {
        EventService.Instance.OnCurrencyChanged.AddListener(OnCurrencyChanged);
    }
    public void Initialize(PlayerInventoryController controller, CurrencyService currencyService)
    {
        this.playerInventoryController = controller;
        this.currencyService = currencyService;

        RefreshInventory();
        UpdateCurrency();
    }
    public void RefreshInventory()
    {
        foreach (Transform child in gridParent)
            Destroy(child.gameObject);

        foreach (var item in playerInventoryController.getPlayerInventoryItems())
        {
            GameObject slot = Instantiate(itemSlotPrefab, gridParent);

            ItemSlotView view = slot.GetComponent<ItemSlotView>();
            view.SetUp(item);
        }

        UpdateWeight();
    }
    private void UpdateWeight()
    {
        float current = playerInventoryController.GetCurrentWeight();
        float max = playerInventoryController.GetMaxWeight();

        weightText.text = "Weight : " + current + " / " + max;
    }

    public void UpdateCurrency()
    {
        currencyText.text = "Currency : " + currencyService.GetCurrency();
    }
    private void OnCurrencyChanged(int amount)
    {
        UpdateCurrency();
    }
}
