using Domain.Core.Models;
using Infrastructure.Data.Registrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class UserRegistrationUI
    {

        public static void UserRegUI()
        {
            ClientUser clientUser = new ClientUser();
            Console.Clear();
            
            Console.Write("Full name: ");
            clientUser.FullName = Console.ReadLine();
            Console.Write("User name: ");
            clientUser.User_name = Console.ReadLine();
           age: Console.Write("Age: ");
            if (!byte.TryParse(Console.ReadLine(), out byte age))
            {
                goto age;
                

            }
            clientUser.Age = age;
            Console.Write("Your number phone: ");
            clientUser.Phone = Console.ReadLine();
            Console.Write("Email: ");
            clientUser.Email=Console.ReadLine();
            Console.Write("Password: ");
            clientUser.Password = Console.ReadLine();
            RegClientUser regClient = new(clientUser);
            if (regClient.RegisterUser())
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                    SUCCSESS!");
                Thread.Sleep(500);
                Console.ResetColor();
                StartInterface.StartRun();
            }    
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("               This user already exist!");
                Thread.Sleep(500);
                Console.ResetColor();
                UserRegUI();
            }


           
            


        }
    }
}
