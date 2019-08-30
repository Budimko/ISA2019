using EasyFlight.Models;
using EasyFlight.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Mapper
{
    public class MapperToDataLoginModel
    {
        public static User FromUserToDataLoginModel(LoginViewModel loginViewModel)
        {
            User user = new User();
            user.Email = loginViewModel.Email;
            user.Password = loginViewModel.Password;
            return user;
        }
    }
}
