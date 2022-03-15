using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Models
{
    public class Journal
    {
        [Key]
        public int JournalNumber { get; set; }
        public string Entry { get; set; }
        public DateTime DateWritten { get; set; }
        public int UserNumber { get; set; }
        [ForeignKey("UserNumber")]
        public User User { get; set; }

    }
}
