public class ItemRepository : BaseRepository<Item>, IItemRepository
{
    public ItemRepository(IRepositoryContext<Item> repositoryContext) : base(repositoryContext)
    {
    }
}