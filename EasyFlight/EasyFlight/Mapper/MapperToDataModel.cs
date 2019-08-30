using EasyFlight.Models;
using EasyFlight.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Mapper
{
    public class MapperToDataModel
    {
        public static User FromUserViewModeToUser(RegisterViewModel registerViewModel)
        {
            Guid Id = Guid.NewGuid();
            User user = new User();
            user.Id = Id;
            user.Name = registerViewModel.Name;
            user.Surname = registerViewModel.Surname;
            user.Email = registerViewModel.Email;
            user.Password = registerViewModel.Password;
            user.Address = registerViewModel.Address;
            user.PhoneNumber = registerViewModel.PhoneNumber;
            user.RoleId = new Guid("dd1239f4-2645-456f-882a-7d2ab7d336b0");
            return user;
        }

    }
}
