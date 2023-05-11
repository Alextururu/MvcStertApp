using MvcStertApp.Models.Db;
using System.Threading.Tasks;

namespace MvcStertApp.Controllers
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUsers();
    }

}
