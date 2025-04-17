using System.ComponentModel.DataAnnotations;

namespace NeatBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }
        public bool IsActive { get; set; }

        public IEnumerable<Product_Prop> ProductProperties { get; set; }

        public Category Category { get; set; }

        public DateOnly AvailableAfter { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }

    public enum Category
    {
        Entree,
        Appetizer,
        Dessert
    }
}
