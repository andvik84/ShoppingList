namespace ShoppingList.Models
{
    public class ItemHistory : DateTimeClass
    {
        public int Id { get; set; }
        public Item Item { get; set; } = new();
        public int ListaId { get; set; } = new();
        public int UsedNumber { get; set; }


    }
}
