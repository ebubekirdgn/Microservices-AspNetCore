namespace FreeCourse.Web.Services.ClientCredentialTokenService
{
    public interface IClientCredentialTokenService
    {
        Task<String> GetToken();
    }
}
