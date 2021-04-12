using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogID { get; set; }

        [StringLength(60, ErrorMessage = "You title should not exceed sixty characters.")]
        [Required]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [Required]

        [Display(Name = "Content")]
        public string Body { get; set; }


        public int AuthorID { get; set; }

        [ForeignKey("AuthorID")]
        public Author Author { get; set; }

        [Editable(false)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

    }
}
