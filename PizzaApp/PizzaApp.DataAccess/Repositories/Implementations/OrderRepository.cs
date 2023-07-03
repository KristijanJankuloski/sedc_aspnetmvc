using Microsoft.EntityFrameworkCore;
using PizzaApp.DataAccess.DataContext;
using PizzaApp.DataAccess.Repositories.Interfaces;
using PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.DataAccess.Repositories.Implementations
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly PizzaAppDbContext _context;
        public OrderRepository(PizzaAppDbContext context)
        {
            _context = context;
        }
        public async Task<int> DeleteById(int id)
        {
            Order order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);
            if(order == null)
            {
                throw new Exception("Order not found");
            }
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return order.Id;
        }

        public async Task<List<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetById(int id)
        {
            return await _context.Orders
                .Include(x => x.User)
                .Include(x => x.PizzaOrders)
                .ThenInclude(x => x.Pizza)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Insert(Order entity)
        {
            await _context.Orders.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Order entity)
        {
            _context.Orders.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
