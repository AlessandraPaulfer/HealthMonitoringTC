using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserRepository
    {
        void Add(UserEntity entity);
        void Update(UserEntity entity);
        UserEntity GetValidateLogin(UserEntity entity);
        UserEntity Login(UserEntity entity);
    }
}
