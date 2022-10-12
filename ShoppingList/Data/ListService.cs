using Microsoft.EntityFrameworkCore;
using ShoppingList.Models;

namespace ShoppingList.Data
{
    public class ListService : IListService
    {
        private readonly ShoppingListDbContext _context;
        public List<Lista> Lists { get; set; } = new List<Lista>();
        public ListService(ShoppingListDbContext context)
        {
            _context = context;
        }

        public async Task LoadLists()
        {
            Lists = await _context.Lists.ToListAsync();
        }

        public async Task CreateList(Lista lista)
        {
            _context.Lists.Add(lista);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteList(Lista lista)
        {
            _context.Lists.Remove(lista);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Lista>> LoadOneList(int id)
        {
            var lista = await _context.Lists
                .Where(l => l.Id == id)
                .Include(l => l.ListItems).ThenInclude(l => l.Item).ThenInclude(i => i.Category).ToListAsync();
            if (lista == null)
                throw new Exception("No such list");
            return lista;
        }

    }
}
