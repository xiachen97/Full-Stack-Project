namespace Api.Translators.User
{
    public interface IUserTranslator
    {
        List<Contracts.User.User> ToApi(List<Business.Contracts.User.User> users);
    }
}
