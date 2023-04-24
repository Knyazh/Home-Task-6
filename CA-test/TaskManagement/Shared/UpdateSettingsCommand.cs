using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Services;

namespace TaskManagement.Shared
{
    public class UpdateSettingsCommand
    {
        public virtual void Handle()
        {
            UserValidator userValidator = new UserValidator();

            UserService.CurrentUser.Name = userValidator.GetAndValidateFirstName();
            UserService.CurrentUser.LastName = userValidator.GetAndValidateLastName();
            UserService.CurrentUser.Password = userValidator.GetAndValidatePassword();
        }
    }
}
