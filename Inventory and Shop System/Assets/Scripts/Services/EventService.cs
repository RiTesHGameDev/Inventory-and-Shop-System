public class EventService 
{
    private static EventService instance;

    public static EventService Instance
    {
        get
        {
            if (instance == null)
                instance = new EventService();

            return instance;
        }
    }

    public EventController OnInventoryChanged;
    public EventController<int> OnCurrencyChanged;
    public EventController<ItemData> OnItemSelection;
    public EventController OnCloseButtonClick;
    public EventService()
    {
        OnInventoryChanged = new EventController();
        OnCurrencyChanged = new EventController<int>();
        OnItemSelection = new EventController<ItemData>();
    }
}
