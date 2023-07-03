using PizzaApp.Domain.Models;
using PizzaApp.ViewModels.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Mappers
{
    public static class UserMapper
    {
        public static UserViewModel ToUserViewModel(this User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
            };
        }

        public static User ToUser(this UserViewModel model)
        {
            return new User
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
            };
        }
    }
}
