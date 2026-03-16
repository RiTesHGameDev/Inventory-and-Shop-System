public class GameService
{
    public PlayerInventoryService playerInventoryService { get; private set; }
    public ShopService shopService { get; private set; }
    public CurrencyService currencyService { get; private set; }

    public GameService(PlayerInventoryView playerInventoryView,ShopView shopView,ItemDatabase database)
    {
        currencyService = new CurrencyService();

        playerInventoryService = new PlayerInventoryService(playerInventoryView,currencyService);

        shopService = new ShopService(database,shopView,playerInventoryService,currencyService);
    }
}
