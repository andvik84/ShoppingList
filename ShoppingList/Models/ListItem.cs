namespace ShoppingList.Models
{
    public class ListItem : DateTimeClass
    {
        public int Id { get; set; }
        public Item Item { get; set; } = new();
        public int ListaId { get; set; }
        public string? ExtraText { get; set; } = string.Empty;
        public int Amount { get; set; }
    }
}
