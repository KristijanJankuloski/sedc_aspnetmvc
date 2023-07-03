using Microsoft.EntityFrameworkCore;
using PizzaApp.DataAccess.DataContext;
using PizzaApp.DataAccess.Repositories.Interfaces;
using PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.DataAccess.Repositories.Implementations {
    public class UserReposiotry : IRepository<User>
    {
        private readonly PizzaAppDbContext _context;

        public UserReposiotry(PizzaAppDbContext context)
        {
            _context = context;
        }

        public async Task<int> DeleteById(int id)
        {
            User user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if(user == null)
            {
                throw new Exception("User not found");
            }
            _context.Users.Remove(user);
            await _context.AddRangeAsync();
            return user.Id;
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _context.Users
                .Include(x => x.Orders)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Insert(User entity)
        {
            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(User entity)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
