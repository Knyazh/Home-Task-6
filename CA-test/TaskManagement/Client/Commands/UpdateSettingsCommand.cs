using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Services;

namespace TaskManagement.Client.Commands
{
    public class UpdateSettingsCommand
    {
        public static void Handle()
        {
            UserValidator userValidator = new UserValidator();

            UserService.CurrentUser.Name = userValidator.GetAndValidateFirstName();
            UserService.CurrentUser.LastName = userValidator.GetAndValidateLastName();
            UserService.CurrentUser.Password = userValidator.GetAndValidatePassword();
        }
    }
}
