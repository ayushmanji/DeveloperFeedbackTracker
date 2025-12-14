using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevFeedbackAPI.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Message { get; set; }

        public string? Tag { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Foreign Key
        public int DeveloperId { get; set; }
        public Developer? Developer { get; set; }
    }

}
