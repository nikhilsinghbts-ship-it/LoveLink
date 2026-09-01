namespace LoveLink.Models
{
    public class Proposal
    {
        public int Id { get; set; }

        public string UniqueCode { get; set; } = "";

        public string YourName { get; set; } = "";

        public string RecipientName { get; set; } = "";

        public string Title { get; set; } = "";

        public string Letter { get; set; } = "";

        public string Password { get; set; } = "";

        public string Theme { get; set; } = "pink";

        public DateTime CreatedAt { get; set; }
    }
}