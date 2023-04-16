using Domain.Core.Models;
using Infrastructure.Data.Commands;
using Infrastructure.Data.Logins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class LoginUIuser
    {
        public static void UIlogin()
        {
            Console.Clear();
            Console.WriteLine("+----------------------------------------------------------------------------+");
            Console.Write("Enter your user name: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                
                if (char.IsLetterOrDigit(key.KeyChar))
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
            }
            while (key.Key != ConsoleKey.Enter);
            LoginClientUser loginClient = new(username, password);
            try
            {
                loginClient.LoginClient();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("                    SUCCSESS!");
                Thread.Sleep(500);
                Console.ResetColor();
                HouseListPrint();



            }
            catch (Exception)
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Password or Username incorrect");
                Console.ResetColor();
                Thread.Sleep(1000);
                UIlogin();



            }


        }
        internal static void HouseListPrint()
        {
            Console.Clear();
            Console.WriteLine("+------------------------------------------------------------PRESS ENTER TO GO TO MAIN--------------------------------------------------------------------+");
            Console.WriteLine();
            HouseRepository houseRepository = new();
            var houses = houseRepository.GetHouses();
            Console.WriteLine("+---------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|{0,-4}|{1,-12}|{2,-30}|{3,-20}|{4,-6}|{5,-10}|{6,-6}|{7,-20}|{8,-15}|{9,-21}|", "ID", "Room Count", "Address", "City", "Sold", "Price", "Area", "Contact Name", "Contact", "Created At");
            Console.WriteLine("+----+------------+------------------------------+--------------------+------+----------+------+--------------------+---------------+---------------------+");

            foreach (House house in houses)
            {
                Console.WriteLine("|{0,-4}|{1,-12}|{2,-30}|{3,-20}|{4,-6}|{5,-10:N}|{6,-6}|{7,-20}|{8,-15}|{9,-21}|", house.House_id, house.Count_Room, house.AddressLine, house.city_name, house.is_sold, house.Price, house.Area, house.Contact_name, house.Contact, house.Created_at.ToString("dd.MM.yyyy HH:mm:ss"));
            }

            Console.WriteLine("+----+------------+------------------------------+--------------------+------+----------+------+--------------------+---------------+---------------------+");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    
                    StartInterface.StartRun();

                    break;
                }
            }
        }

    }
}
