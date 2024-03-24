namespace PROJECT_PRN231.Models
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public int UserId { get; set; }

        public string Username { get; set; } = null!;
        public int? Roleid { get; set; }
    }
}
