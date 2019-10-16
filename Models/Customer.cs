using System.ComponentModel.DataAnnotations;

namespace WebAPIBaseData.Models
{
    public class Customer
    {
        public long Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}