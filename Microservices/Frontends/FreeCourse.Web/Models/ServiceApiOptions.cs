namespace FreeCourse.Web.Models
{
    public class ServiceApiOptions
    {
        public const string Option = "ServiceApiOptions";
        public string IdentityBaseUri { get; set; }
        public string GatewayBaseUri { get; set; }
        public string PhotoStockUri { get; set; }
    }
}