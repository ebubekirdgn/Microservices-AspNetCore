namespace FreeCourse.Web.Models
{
    public class ClientOptions
    {
        public const string Option = "ClientOptions";
        public Client WebClient { get; set; }
        public Client WebClientForUser { get; set; }
    }
    public class Client
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
