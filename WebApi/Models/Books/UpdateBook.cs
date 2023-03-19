using DataLayer.Domain;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Books
{
    public class UpdateBook
    {
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
        public int PublisherId { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
    }
}
