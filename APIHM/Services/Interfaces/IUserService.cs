using Common;

namespace APIHM.Services.Interfaces
{
    public interface IUserService
    {
        void AddUser(UserModel model);
        UserModel Login(UserModel user);
        void UpdateUser(UserModel model);
    }
}
