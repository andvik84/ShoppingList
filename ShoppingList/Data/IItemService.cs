using ShoppingList.Models;

namespace ShoppingList.Data
{
    public interface IItemService
    {
        List<Item> items { get; set; }
        List<ListItem> listItems { get; set; }
        Task LoadItems(int listaId);
        Task CreateItem(Item item);
        Task AddItem(ListItem listItem);
        //Task UpdateList(Lista list);
        Task DeleteItem(ListItem listItem);

        Task<List<Lista>> LoadOneList(int id);

    }
}
