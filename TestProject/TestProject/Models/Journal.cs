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
        public int OwnerUserNumber { get; set; } //the system wants to have it written like this 
        public int EditorUserNumber { get; set; }
        public User Owner { get; set; }
        public User Editor { get; set; }
        [ForeignKey("JournalNumber")]
        public ICollection<Comment> Comments { get; set; }
        public Journal()
        {
            Comments = new HashSet<Comment>();
        }
    }
}
