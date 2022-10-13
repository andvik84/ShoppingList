using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Models
{
    public enum AmountUnit
    {
        None,
        Kg,
        St,
        Liter,
    };

    public class Item : DateTimeClass
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public AmountUnit AmountUnit { get; set; } = AmountUnit.None;
        public ItemCategory? Category { get; set; }
    }
}