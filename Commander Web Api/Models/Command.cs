using System.ComponentModel.DataAnnotations;

namespace Commander_Web_Api.Models
{
    public class Command
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }
        
        [Required]
        public string Plateform { get; set; }
    }

}
