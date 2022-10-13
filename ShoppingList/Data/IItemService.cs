using ShoppingList.Models;

namespace ShoppingList.Data
{
    public interface IItemService
    {
        List<Item> items { get; set; }
        List<ListItem> listItems { get; set; }
        Task LoadItems(int listaId);
        Task CreateItem(Item item);
        Task AddItemToList(Item item, int listaId);
        //Task UpdateList(Lista list);
        Task DeleteItem(Item item);

        //Task<List<Lista>> LoadOneList(int id);

    }
}
