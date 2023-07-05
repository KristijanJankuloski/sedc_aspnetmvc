using PizzaApp.DataAccess.Repositories.Interfaces;
using PizzaApp.Domain.Models;
using PizzaApp.Mappers;
using PizzaApp.Services.Interfaces;
using PizzaApp.ViewModels.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        public UserService(IRepository<User> repository)
        {
            _userRepository = repository;
        }
        public async Task CreateUser(UserViewModel user)
        {
            await _userRepository.Insert(user.ToUser());
        }

        public async Task<List<UserSelectListViewModel>> GetAllSelectList()
        {
            List<User> user = await _userRepository.GetAll();
            return user.Select(u => u.ToUserSelectList()).ToList();
        }
    }
}
