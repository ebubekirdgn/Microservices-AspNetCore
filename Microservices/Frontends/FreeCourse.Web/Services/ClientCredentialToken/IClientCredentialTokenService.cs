namespace FreeCourse.Web.Services.ClientCredentialToken
{
    public interface IClientCredentialTokenService
    {
        Task<string> GetToken();
    }
}