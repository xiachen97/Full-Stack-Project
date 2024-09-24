namespace Business.Translators.User;

public interface IUserTranslator
{
    List<Contracts.User.User> ToBusiness(List<Data.Contracts.User.User> users);
}