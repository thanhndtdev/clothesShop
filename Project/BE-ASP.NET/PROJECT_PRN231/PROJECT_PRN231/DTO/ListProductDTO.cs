namespace PROJECT_PRN231.DTO
{
    public class ListProductDTO
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public int? CategoryId { get; set; }

        public decimal? Price { get; set; }

        public int? qty { get; set; }

        public string? Image { get; set; }

        public string? Category { get; set; }

        public string? Description { get; set; }
    }
}
