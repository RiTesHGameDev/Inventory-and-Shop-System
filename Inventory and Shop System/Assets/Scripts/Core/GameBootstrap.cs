using UnityEngine;

public class GameBootstrap : MonoBehaviour
{
    [Header("Views")]
    public PlayerInventoryView inventoryView;
    public ShopView shopView;

    [Header("Data")]
    public ItemDatabase itemDatabase;

    private GameService gameService;

    public GatherResource gatherResource;

    void Awake()
    {
        gameService = new GameService(inventoryView, shopView, itemDatabase);
        gatherResource.Initialize(gameService.currencyService, gameService.playerInventoryService.GetController());
    }
}