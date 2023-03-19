using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Domain
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 10)]
        public string Title { get; set; }
        [Required]
        public BookType Type { get; set; }
        [Required]
        public string UrlDownload { get; set; }

        public string Note { get; set; }

		// Relationship
		[ForeignKey(nameof(Publisher))]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public DateTime PublishedDate { get; set; }

    }

    
}
