
namespace strategy.Models
{
    public class AccountActive
    {
        public string Email { get; set; }
        public string ActiveValue { get; set; }
    }

    public class AccountProject // not use inherit cause of AsEnumerable error EF core
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Id { get; set; }
        public string Email { get; set; }
    }

    public class AccountId
    {
        public long Id { get; set; }
    }

    public class AccountPass
    {
        public long Id { get; set; }
        public string Password { get; set; }
    }
}
