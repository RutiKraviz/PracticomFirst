using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> AddAsync(int id, string lastName, string firstName, DateTime birthDate, EType type, EHMO HMO);
        Task<User> UpdateAsync(int id, User user);
        Task DeleteAsync(int id);
    }
}
