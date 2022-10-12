namespace ShoppingList.Models
{
    public class Lista : DateTimeClass
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<ListItem>? ListItems { get; set; }

    }
}
