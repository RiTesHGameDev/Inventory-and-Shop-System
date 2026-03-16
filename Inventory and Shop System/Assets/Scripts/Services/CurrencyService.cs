public class CurrencyService
{
    private int currency = 0;

    public int GetCurrency()
    {
        return currency;
    }

    public bool CanSpend(int amount)
    {
        return currency >= amount;
    }

    public void Add(int amount)
    {
        currency += amount;
        EventService.Instance.OnCurrencyChanged.InvokeEvent(currency);
    }

    public void Remove(int amount)
    {
        currency -= amount;
        EventService.Instance.OnCurrencyChanged.InvokeEvent(currency);
    }
}
