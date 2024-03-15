﻿using EcommerceWebSite.App.Contract;
using EcommerceWebSite.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebSite.App.Services
{
    public class UserService
    {
        IUserService _userService;
        public UserService(IUserService userService)
        {
            _userService = userService;
        }
        public Task<User> UserRegister(User user)
        {
            if (user is not null && _userService.GetByEmail(user.Email) is null)
            {
                var _user = _userService.CreateAsync(user);
                return _user;
            }
            return null;
        }
        public Task<User> UpdateUser(User user)
        {
            if (user is not null)
            {
                return _userService.UpdateAsync(user);
            }
            return null;
        }
        public Task<User> DeleteUser(User user)
        {
            if (user is not null)
            {
                Task<User> _user = _userService.DeleteAsync(user);
                _userService.SaveChangesAsync();
                return _user;
            }
            return null;
        }
        public Task<User> GetUser(int id)
        {
            if (id != 0)
            {
                return _userService.GetByIdAsync(id);
            }
            return null;
        }
        public User Login(string Email, string passwrd)
        {
            return _userService.Login(Email, passwrd);
        }
    }
}
