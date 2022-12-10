public class ItemConfigLoader : BaseConfigLoader<IEnumerable<Item>>, IItemConfigLoader
{
    public ItemConfigLoader(HttpClient http) : base(http, "config/item-config.json")
    {
    }
}