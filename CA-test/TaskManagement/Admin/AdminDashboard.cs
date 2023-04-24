using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.Commands;
using TaskManagement.Database;
using TaskManagement.Shared;

namespace TaskManagement.Admin
{
    public class AdminDashboard
    {
        public static void Introduction()
        {
            Console.WriteLine("Hello dear admin");
            Console.WriteLine();

            Console.WriteLine("Aviable commands:");
            Console.WriteLine("/promote-to-admin");
            Console.WriteLine("/depromote-from-admin");
            Console.WriteLine("/message-to");
            Console.WriteLine("/ban-user");
            Console.WriteLine("/update-user-settings");
            Console.WriteLine("/remove-user");
            Console.WriteLine("/show-users");
            Console.WriteLine("/show-user-by-email");
            Console.WriteLine("/show-user-by-id");
            Console.WriteLine("//add-user");
            Console.WriteLine("/logout");
            UpdateSettingsCommandForAdmin updateSettingsCommandForAdmin = new UpdateSettingsCommandForAdmin();

            while (true)
            {
                Console.Write("Enter command:");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/promote-to-admin":
                        PromoteToAdminCommand.Handle();
                        break;
                    case "/depromote-from-admin":
                        DePromoteFromAdminCommand.Handle();
                        break;
                    case "/message-to":
                        SendMessageCommand.Handle();
                        break;
                    case "/ban-user":
                        BanUserCommand.Handle();
                        break;
                    case "/update-user-settings":
                        updateSettingsCommandForAdmin.Handle();
                        break;
                    case "/remove-user":
                        RemoveUserCommand.Handle();
                        break;
                    case "/show-users":
                        ShowUsersCommand.Handle();
                        break;
                    case "/show-user-by-email":
                        ShowUserByEmailCommand.Handle();
                        break;
                    case "/show-user-by-id":
                        ShowUserByIdCommand.Handle();
                        break;
                    case "/add-user":
                        AddUserCommand.Handle();
                        break;
                    case "/logout":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }
    }
}
