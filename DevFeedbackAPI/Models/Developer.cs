using System.ComponentModel.DataAnnotations;

namespace DevFeedbackAPI.Models
{
    public class Developer
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        [EmailAddress]
        public required string Email { get; set; }

        public required string PasswordHash { get; set; }

        public List<Feedback> Feedbacks { get; set; } = new();
    }
}
