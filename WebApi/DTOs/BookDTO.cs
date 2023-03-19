namespace WebApi.DTOs
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TypeResponse Type { get; set; }
        public string UrlDownload { get; set; }
        public string Note { get; set; }
        public PublisherDTO Publisher { get; set; }

        public string PublishedDate { get; set; }
    }
}
