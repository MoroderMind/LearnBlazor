using System.ComponentModel.DataAnnotations;

namespace LearnBlazor.Models
{
    public class Product
    {
        public Product()
        {
            AvaliableAfter = DateOnly.FromDateTime(DateTime.Now);
        }
        public int Id{ get; set; }
        [Required]
        public string Name{ get; set; }
        [Range(1,1000)]
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<Product_Prop> ProductProperties { get; set; }

        public Category Category { get; set; }
        public DateOnly AvaliableAfter { get; set; }



    }
    public enum Category
    {
        Entree,
        Appetizer,
        Dessert
    }
}
