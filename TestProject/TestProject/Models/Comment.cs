using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Models
{
    public class Comment
    {
        [Key]
        public int CommentNumber { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public int JournalNumber { get; set; }
        public int? UserNumber { get; set; }
        public User? User { get; set; }
        public Journal Journal { get; set; }
    }
}
