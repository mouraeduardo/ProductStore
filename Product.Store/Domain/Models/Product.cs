using System.ComponentModel.DataAnnotations.Schema;

namespace ProductStore.Domain.Models
{
    [Table("Product")]
    public class Product
    {
        [Column("Id")]
        public long Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("Price")]
        public double Price  { get; set; }
        [Column("Brand")]
        public string Brand { get; set; }
        [Column("QuantityInStock")]
        public long QuantityInStock { get; set; }
    }
}
