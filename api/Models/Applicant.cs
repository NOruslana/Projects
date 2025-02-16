namespace api.Models
{
    public class Applicant
    {
        public int ApplicantId { get; set; }
        public string ApplicantName { get; set; }
        public Position Position { get; set; }
        public string? Description { get; set; }
    }
}
