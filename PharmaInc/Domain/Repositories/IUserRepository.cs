using Domain.Entities;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        void Create(User user);
        void Update(User user);
        void Delete(User user);
        User GetById(string name, string value);
    }
}