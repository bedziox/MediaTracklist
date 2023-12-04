using MediaTracklist.Models;

namespace MediaTracklist.Repositories;


public interface IUserRepository
{
    IEnumerable<User> GetAll();
    User GetById(int userId);
    void Insert(User user);
    void Update(User user);
    void Delete(int userId);
    void Save();
}
