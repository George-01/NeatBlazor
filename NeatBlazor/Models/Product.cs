namespace NeatBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }

        public IEnumerable<Product_Prop> ProductProperties { get; set; }
    }
}
