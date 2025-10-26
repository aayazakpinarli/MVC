using CORE.APP.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace APP.Domain
{
    public class User : Entity
    {
        [Required, StringLength(30)]
        public string UserName { get; set; }

        [Required, StringLength(15)]
        public string Password { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public Genders Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool IsActive { get; set; }

        public string Address { get; set; }

    }
}