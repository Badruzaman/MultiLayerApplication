namespace MultiLayerApplication.Api.Contracts
{
    public class ErrorResponse
    {
        public string StatusCode { get; set; }
        public string StatusPhase { get; set; }
        public DateTime Timestamp { get; set; }
        public List<string> Errors { get; set; }
    }
}
