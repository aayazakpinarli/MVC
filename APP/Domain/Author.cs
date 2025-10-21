using CORE.APP.Domain;

namespace APP.Domain
{
    public class Author : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Book Book { get; set; }

    }
}
