using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [InverseProperty("Owner")] //name of the object
        public ICollection<Journal> Journals { get; set; }
        [InverseProperty("Editor")]//name of the object
        public ICollection<Journal> EditedJournals { get; set; }
        [ForeignKey("UserNumber")]
        public ICollection<Comment> Comments { get; set; }
        public User()
        {
            Journals = new HashSet<Journal>();
            EditedJournals = new HashSet<Journal>();
            Comments = new HashSet<Comment>();
        }
    }
}


/*

I want to have one person initialize the project, and another team member pull that project, and 
create a new branch to add second and third classes.

One member should create the first class and scaffold the context
The second member should create a new branch and add the second and third classes, and annotate them.

They should then merge those changes to the Main branch.

The first student will then pull those changes after they are pushed.

Second Half:
Before you start, make sure that whoever owns the repository has merged in the branch of our last of work into main

Add a new type of User to the relation of each journal called an Editor, 
so that Users have a list of Journals that they Edit and Journals that they own

Also each Journal should track the day that it was created, 
and that should appear in a day-month-year format.

Create a new branch for this set of features. 
And have anyone who does not own the repository merge the new changes into the main branch 
and update their database to reflect those changes.

 */
