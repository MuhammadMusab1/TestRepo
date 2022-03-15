using System.ComponentModel.DataAnnotations;

namespace TestProject.Models
{
    public class User
    {
        [Key]
        public int UserNumber { get; set; } //don't use Ids
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name has to have more than 3 characters and fewer than 100")]
        public string FirstName { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name has to have more than 3 characters and fewer than 100")]
        public string LastName { get; set; }
    }
}
