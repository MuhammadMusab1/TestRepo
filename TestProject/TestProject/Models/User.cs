﻿using System.ComponentModel.DataAnnotations;

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


/*

I want to have one person initialize the project, and another team member pull that project, and 
create a new branch to add second and third classes.

One member should create the first class and scaffold the context
The second member should create a new branch and add the second and third classes, and annotate them.

They should then merge those changes to the Main branch.

The first student will then pull those changes after they are pushed.

 */
