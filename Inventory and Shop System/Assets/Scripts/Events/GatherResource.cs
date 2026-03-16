using UnityEngine;
using UnityEngine.UI;

public class GatherResource : MonoBehaviour
{
    public Button gatherButton;
    public GameObject gatherResourcePanel;

    private CurrencyService currencyService;
    private PlayerInventoryController inventoryController;

    public void Initialize(CurrencyService currencyService,
                           PlayerInventoryController inventoryController)
    {
        this.currencyService = currencyService;
        this.inventoryController = inventoryController;
    }

    private void Awake()
    {
        gatherButton.onClick.AddListener(OnGatherButtonClick);
    }

    private void OnGatherButtonClick()
    {
        Gather();
        gatherResourcePanel.SetActive(false);
    }

    private void Gather()
    {
        currencyService.Add(1000);
        inventoryController.IncreaseCapacity(200);

        Debug.Log("Resources gathered!");
    }
}
