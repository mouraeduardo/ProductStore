using System.ComponentModel.DataAnnotations.Schema;

namespace ProductStore.Domain.Models
{
    [Table("User")]
    public class User
    {
        [Column("Id")]
        public long Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Cpf")]
        public string Cpf { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("TellPhone")]
        public string TellPhone { get; set; }
        [Column("Password")]
        public string Password { get; set; }
    }
}
