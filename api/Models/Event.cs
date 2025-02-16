using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace api.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string? EventDescription { get; set; }
        public EventStatus EventStatus { get; set; }
        public EventType EventType { get; set; }
        public DateTime EventDate { get; set; } = DateTime.Now;
        public double? EventTime { get; set; }
        public Worker? Organizator { get; set; }

    }
}
