using Matches.Entities;

namespace Matches
{
    public class DataContext
    {
        public int count = 100;
        public List<Matchmaker> matchmakers { get; set; }
        public List<Matchmaking> matchmaking { get; set; }
        public List<MeetingPlace> meetingPlace { get; set; }

        public DataContext()
        {
            matchmakers = new List<Matchmaker>();
            matchmakers.Add(new Matchmaker { Id = count++, FirstName = " FirstName", LastName = "LastName", Email = "Email@gmail.com", Phone = "0554455445" });
            matchmaking = new List<Matchmaking>();
            matchmaking.Add(new Matchmaking { Id = 123456789, FirstName = " FirstName", LastName = "LastName", Email = "Email@gmail.com", Phone = "0554455445", Age = 19, IsChoen = false, status = Status.Single });
            meetingPlace = new List<MeetingPlace>();
            meetingPlace.Add(new MeetingPlace { NamePlace = "NamePlace", IsActive = true, Descriptuon = "Descriptuon", IsSatisfied = true });

        }

    }
}

