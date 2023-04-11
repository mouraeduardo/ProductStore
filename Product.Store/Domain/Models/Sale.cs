using System.ComponentModel.DataAnnotations.Schema;

namespace ProductStore.Domain.Models
{
    [Table("Sale")]
    public class Sale
    {
        [Column("SaleId")]
        public long SaleId { get; set; }
        [Column("ProductId")]
        public long Product { get; set; }
        [Column("DateSale")]
        public DateTime DateSale { get; set; }
    }
}
