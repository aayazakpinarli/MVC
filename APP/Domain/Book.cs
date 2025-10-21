using CORE.APP.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace APP.Domain
{
    public class Book : Entity
    {
        [Required, StringLength(30)]
        public string Name { get; set; }

        public short? NumberOfPages { get; set; }

        public DateTime? PublishDate { get; set; }

        public decimal Price { get; set; }

        public bool IsTopSeller { get; set; }

        public int AuthorId{ get; set; }
        
    }
}