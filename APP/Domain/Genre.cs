using CORE.APP.Domain;

namespace APP.Domain
{
    public class Genre : Entity
    {
        public string Name { get; set; }

        public Book Book { get; set; }

    }
}
