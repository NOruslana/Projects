namespace api.Models
{
    public class Dissmised
    {
        public int DissmisedId { get; set; }
        public Worker DissmisedName { get; set; }
        public DateOnly DissmisedDate { get; set; }
        public string Description { get; set; }

    }
}
