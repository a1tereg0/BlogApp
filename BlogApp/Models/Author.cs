using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorID { get; set; }

        [Display(Name = "First Name")]
        [StringLength(20, ErrorMessage = "Your first name cannot exceed 20 characters")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "Your last name cannot exceed 20 characters")]
        [Required]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Birthday { get; set; }

        public byte Age => (byte)(DateTime.Now.Year - Birthday.Year);

        [Display(Name = "Email Address")]
        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }

        [Display(Name = "Web site")]
        [Url]
        public string WebAddress { get; set; }

        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }

        public string Country { get; set; }

        public string Province { get; set; }

        [Display(Name = "Postal/Zip Code")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        public ICollection<Blog> blogs;

    }
}
