using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Teeth.Domain.Models;

namespace Teeth.Domain.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAlUsersAsync();

        Task<User> GetByIdAsync(int id);

        Task<User> CreateAsync(User user);

        Task<int> UpdateAsync(int id, User user);

        Task<int> DeteteAsync(int id);
    }
}
