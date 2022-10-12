using ShoppingList.Models;

namespace ShoppingList.Data
{
    public interface IListService
    {
        List<Lista> Lists { get; set; }
        Task LoadLists();
        Task CreateList(Lista list);
        //Task UpdateList(Lista list);
        Task DeleteList(Lista list);

        Task<List<Lista>> LoadOneList(int id);
        
    }
}
