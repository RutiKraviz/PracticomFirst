using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class ChildRepository: IChildRepository1
    {
        private readonly IContext _context;

        public ChildRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(int id, string lastName, string firstName, DateTime birthDate, User parent)
        {
            var c = new Child() { Id = id, FirstName = firstName, LastName = lastName, BirthDate = birthDate, Parent = parent };
            _context.Children.Add(c);
            await _context.SaveChangesAsync();
            return c;
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }

        public Task<Child> GetByIdAsync(int id)
        {
            
        }

        public Task<Child> UpdateAsync(int id, Child child)
        {
            throw new NotImplementedException();
        }
        public Task DeleteAsync(int id)
        {
            _context.Children.Remove();
        }
    }
}
