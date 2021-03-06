namespace ResourceServer.Model.Deal
{
    public class Deal
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public long OldPrice { get; set; }
        public long NewPrice { get; set; }
        public string ProductLink { get; set; } = string.Empty;
        public long Rating { get; set; }
        public string Timestamp { get; set; } = string.Empty;
        public string ProductImage { get; set; } = string.Empty;
    }
}
