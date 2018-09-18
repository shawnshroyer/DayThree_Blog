using System.ComponentModel.DataAnnotations;


namespace DayThree_Blog.Models
{
    public class EmailModel
    {
        [Required, Display(Name = "Name")]
        public string FromName { get; set; }
        [Required, Display(Name = "Email"), EmailAddress]
        public string FromEmail { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required, DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}