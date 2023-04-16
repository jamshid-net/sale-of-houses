using Domain.Core.Models;
using Domain.Interfaces;
using Infrastructure.Data.Commands;
using Infrastructure.Data.Logins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class LoginUIBroker
    {
        private static HouseRepository? houseRepository = new();
        public static void LoginBrUI()
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
            LoginBroker loginBroker = new(username, password);
            try
            {

                houseRepository._broker = loginBroker.LoginBr();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("                    SUCCSESS!");
                Thread.Sleep(500);
                Console.ResetColor();
                BrokerMenu();
                

               



            }
            catch (Exception)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password or Username incorrect");
                Console.ResetColor();
                Thread.Sleep(1000);
                LoginBrUI();



            }


        }
        private static void BrokerMenu()
        {
            Console.Clear();
            Console.WriteLine("+----------------------------------------------------------------------------+");
            Console.WriteLine("|1.Create house                                                              |");
            Console.WriteLine("|2.Delete house                                                              |");
            Console.WriteLine("|3.Update house                                                              |");
            Console.WriteLine("|4.See    houses                                                             |");
            Console.WriteLine("+----+----------------------+--------------+---------------------------------+");
            if (!byte.TryParse(Console.ReadLine(), out byte chooseOne))
            {
                Console.Clear();
                BrokerMenu();

            }
            switch (chooseOne)
            {
                case 1: CreateHouseBr(); break;
                case 2: DeleteHouseByIdBrokorUI(); break;
                case 3: UpdateHouseBrokerUI(); break;
                case 4: HouseList(); break;
                default:
                    break;
            }
        }
        private static void CreateHouseBr()
        {
            House house = new House();
            Console.Write("Area of house: "); 
            house.Area = Console.ReadLine();
            Console.Write("Count of room: ");
            if (!int.TryParse(Console.ReadLine(), out int roomCount))
            {
                Console.Clear();
                CreateHouseBr();

            }
            house.Count_Room= roomCount;
            Console.WriteLine("City id, from 1 to 31");
            Console.Write("id: ");
            if (!int.TryParse(Console.ReadLine(), out int cityId))
            {
                Console.Clear();
                CreateHouseBr();

            }
            house.City_id= cityId;
            Console.Write("AdressLine: ");
            house.AddressLine = Console.ReadLine();
            Console.Write("Price: ");
            house.Price = Console.ReadLine();
            houseRepository.CreateHouse(house);
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("SUCCSESS");
            Thread.Sleep(1000);
            Console.ResetColor();
            BrokerMenu();


        }
        private static void DeleteHouseByIdBrokorUI()
        {
            Console.Clear();
            Console.WriteLine("+---------PRESS ENTER TO GO TO BACK---------+");
           
            Console.WriteLine("+-------You can delete only own data!-------+");
            Console.Write("Enter your house id: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {

                while(true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter) BrokerMenu();

                    else DeleteHouseByIdBrokorUI();
                }
                

            }
            houseRepository.DeleteHouse(id);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SUCCSESS");
            Console.ResetColor();
            Thread.Sleep(1000);
            BrokerMenu();
           

        }
        private static void UpdateHouseBrokerUI()
        {
            House house = new House();

            Console.Clear();
            Console.WriteLine("+---------PRESS ENTER TO GO TO BACK---------+");

            Console.WriteLine("+-------You can update only own data!-------+");
            Console.WriteLine("+--NOTE! If your value will be null, value sets old default value--+");
            Console.Write("Enter your house id: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {

                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter) BrokerMenu();

                    else UpdateHouseBrokerUI();
                }


            }
            house.House_id = id;
            Console.Write("New Area: ");
            house.Area = Console.ReadLine();
            Console.Write("New Count room: ");
            if (!int.TryParse(Console.ReadLine(), out int countroom))
            {

                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter) goto next;

                    else UpdateHouseBrokerUI();
                }


            }


            house.Count_Room = countroom;
        next:    
            Console.Write("New Price: ");

            house.Price = Console.ReadLine();
            Console.Write("House is sold? True or False : ");
            if (!bool.TryParse(Console.ReadLine(), out bool isSold))
            {
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter) goto next2;

                    else UpdateHouseBrokerUI();
                }

            }
         
            house.is_sold = isSold;
           next2:
            houseRepository.UpdateHouse(house);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SUCCSESS");
            Console.ResetColor();
            Thread.Sleep(1000);
            BrokerMenu();



        }
       



        private static void HouseList()
        {
            Console.Clear();
            Console.WriteLine("+------------------------------------------------------------PRESS ENTER TO GO TO BACK--------------------------------------------------------------------+");
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

                    BrokerMenu();

                    break;
                }
            }
        }
    }
}
