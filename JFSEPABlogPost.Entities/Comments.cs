using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JFSEPABlogPost.Models
{
    public class Comments
    {
        [Key]
        public int CommId { get; set; }
        [Required(ErrorMessage ="Comments is Required")]
        [Display(Name = "Comment on Post")]
        public string CommentMsg { get; set; }
        [Display(Name = "Commented Date")]
        public DateTime CommentedDate { get; set; } = DateTime.Now;

        [Display(Name = "Post ID")]
        public virtual int PostID { get; set; }
        [ForeignKey("PostID")]
        public virtual BlogPost BlogPosts { get; set; }

        //[Display(Name = "UserId")]
        //public virtual int UserId { get; set; }
        //[ForeignKey("UserId")]
        //public virtual User Users { get; set; }

    }
}
