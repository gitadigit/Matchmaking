namespace Matches.Entities
{
       public enum Status { Single, Widow, Divorcee }

    public class Matchmaking
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Age { get; set; }
        public bool IsChoen { get; set; }
        public Status status { get; set; }
    }
}
