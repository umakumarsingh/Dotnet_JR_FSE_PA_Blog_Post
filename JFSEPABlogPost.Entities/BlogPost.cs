using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JFSEPABlogPost.Models
{
    public class BlogPost
    {
        [Key]
        public int PostID { get; set; }
        [Display(Name = "Blog Title")]
        [Required(ErrorMessage ="Post Title is Required")]
        public string Title { get; set; }

        [Display(Name = "Blog Description")]
        [Required(ErrorMessage ="Post description is required")]
        public string Description { get; set; }
        [Display(Name = "Posted Date")]
        public DateTime PostedDate { get; set; } = DateTime.Now;

        public ICollection<Comments> Comments { get; set; }
    }
}
