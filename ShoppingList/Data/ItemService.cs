using ShoppingList.Models;

namespace ShoppingList.Data
{
    public class ItemService : IItemService
    {
        private readonly ShoppingListDbContext _context;
        public List<Item> items { get; set; }
        public List<ListItem> listItems { get; set; }
        public ItemService(ShoppingListDbContext context)
        {
            _context = context;
        }
        public async Task LoadItems(int listaId)
        {
            throw new NotImplementedException();
        }
        public async Task CreateItem(Item item)
        {
            throw new NotImplementedException();
        }
        public async Task AddItemToList(Item item, int listaId)
        {
            if (!_context.Items.Any(x => x.Name == item.Name))
            {
                _context.Items.Add(item);
                await _context.SaveChangesAsync();
            }
            if (!_context.ListItems.Any(x => x.Item == item))
            {
                _context.ListItems.Add(new ListItem() { Item = item, ListaId = listaId });
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Item already exist in that list");
            }
        }
        //Task UpdateList(Lista list);
        public async Task DeleteItem(Item item)
        {
            throw new NotImplementedException();
        }
        //Task<List<Lista>> LoadOneList(int id)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
