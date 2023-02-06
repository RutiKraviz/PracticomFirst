using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IChildRepository1
    {
        Task<List<Child>> GetAllAsync();
        Task<Child> GetByIdAsync(int id);
        Task<Child> AddAsync(int id, string lastName, string firstName, DateTime birthDate, User parent);
        Task<Child> UpdateAsync(int id, Child child);
        Task DeleteAsync(int id);
    }
}
