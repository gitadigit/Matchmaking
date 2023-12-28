using Matches.Entities;
using Microsoft.EntityFrameworkCore;

namespace Matches
{
    public class DataContext: DbContext
    {
        public int count = 100;
        public DbSet<Matchmaker> matchmakers { get; set; }
        public DbSet<Matchmaking> matchmaking { get; set; }
        public DbSet<MeetingPlace> meetingPlace { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=adiMatches_db");
        }


        public DataContext()
        {
            //matchmakers = new List<Matchmaker>();
            //matchmakers.Add(new Matchmaker { Id = count++, FirstName = " FirstName", LastName = "LastName", Email = "Email@gmail.com", Phone = "0554455445" });
            //matchmaking = new List<Matchmaking>();
            //matchmaking.Add(new Matchmaking { Id = 123456789, FirstName = " FirstName", LastName = "LastName", Email = "Email@gmail.com", Phone = "0554455445", Age = 19, IsChoen = false, status = Status.Single });
            //meetingPlace = new List<MeetingPlace>();
            //meetingPlace.Add(new MeetingPlace { NamePlace = "NamePlace", IsActive = true, Descriptuon = "Descriptuon", IsSatisfied = true });

        }

    }
}

