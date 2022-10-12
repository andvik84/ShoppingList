using ShoppingList.Models;

namespace ShoppingList.Data
{
    public class ItemService : IItemService
    {
        private readonly ShoppingListDbContext _context;
        public List<Item> items { get; set; }
        public List<ListItem> listItems { get; set; }
        public async Task LoadItems(int listaId);
        Task CreateItem(Item item);
        Task AddItem(ListItem listItem);
        //Task UpdateList(Lista list);
        Task DeleteItem(ListItem listItem);

        Task<List<Lista>> LoadOneList(int id);

    }
}
