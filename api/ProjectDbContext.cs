using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<CalendarAbsence> CalendarAbsence { get; set; }
        public DbSet<CalendarEducation> CalendarEducation { get; set; }
        public DbSet<Depatment> Depatments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Dissmised> Dissmised { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventStatus> EventsStatus { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<TypeAbsence> TypeAbsence { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
