using APIHM.Services.Interfaces;
using Common;
using Repository;
using Repository.Entities;
using Repository.Repositories.Interfaces;

namespace APIHM.Services
{
    public class UserService : IUserService
    {
        public readonly IUserRepository repository;
        public readonly IPersonRepository _personrepository;

        public UserService(IUserRepository repository, IPersonRepository personrepository)
        {
            this.repository = repository;
            this._personrepository = personrepository;
        }

        public void AddUser(UserModel model)
        {
            UserEntity entity = new UserEntity()
            {
                PersonId = model.PersonId,
                Password = model.Password
            };   
            repository.Add(entity);
        }
        public void UpdateUser(UserModel model)
        {
            UserEntity entity = new UserEntity()
            {
                Id = model.Id,
                PersonId = model.PersonId,
                Password = model.Password
            };   
            repository.Update(entity);
        }
        public UserModel Login(UserModel model)
        {
            UserEntity entity = new UserEntity()
            {
                Person = new PersonEntity()
                {
                    Email = model.Person.Email
                },
                Password = model.Password,
            };

            entity = repository.Login(entity);

            if (entity != null)
            {
                model.Id = entity.Id;
                model.PersonId = entity.PersonId;
                return model;
            }

            return null;

        }
    }
}
