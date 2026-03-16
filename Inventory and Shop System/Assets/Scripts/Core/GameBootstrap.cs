using UnityEngine;

public class GameBootstrap : MonoBehaviour
{
    [Header("Views")]
    public PlayerInventoryView inventoryView;
    public ShopView shopView;

    [Header("Data")]
    public ItemDatabase itemDatabase;

    private GameService gameService;

    void Awake()
    {
        gameService = new GameService(inventoryView, shopView, itemDatabase);
    }
}