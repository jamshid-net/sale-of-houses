using Dapper;
using Domain.Core.Models;
using Domain.Interfaces;
using Infrastructure.Data.Connections;
using Infrastructure.Data.Logins;
using Npgsql;
using System.Data;
using System.Data.Common;

namespace Infrastructure.Data.Commands
{

    public class HouseRepository : IHouseRepository
    {



        public  Broker _broker { get; set; }

        public HouseRepository(string user_name, string password)
        {
            LoginBroker loginBroker = new LoginBroker(user_name, password);
            _broker = loginBroker.LoginBr();

        }
        public HouseRepository()
        {
            
        }
        async public Task CreateHouse(House house)
        {
            await Task.Run(() =>
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Connection.GetString()))
                {

                    conn.Open();
                    conn.Query<House>
                        ($@"INSERT INTO house
	                    (area, count_room, city_id, addressline, price, creator_broker_id)
	                    VALUES (@area, @count_room, @city_id, @address, 
                            @price, @broker_id);", new
                        {
                            area = house.Area,
                            count_room = house.Count_Room,
                            city_id = house.City_id,
                            address = house.AddressLine,
                            price = house.Price,
                            broker_id = _broker.Broker_id
                        });
                 
                }


            });



             }

            //async public Task CreateHouse(House house)
            //{
            //    await Task.Run(() =>
            //    {
            //        using (NpgsqlConnection conn = new NpgsqlConnection(Connection.GetString()))
            //        {
            //            conn.Open();
            //            conn.Query<House>
            //                ($@"INSERT INTO house
            //             (area, count_room, city_id, addressline, price, creator_broker_id)
            //             VALUES ('{house.Area}', '{house.Count_Room}', '{house.City_id}', '{house.AddressLine}', 
            //                    '{house.Price}', '{_broker.Broker_id}');");
            //        }
            //        //after price : 20',2);delete from house where house_id = 8;--

            //    });



            //}
            async public Task DeleteHouse(int HouseId)
        {

           await  Task.Run(() =>
             {
                 using (NpgsqlConnection conn = new NpgsqlConnection(Connection.GetString()))
                 {
                     conn.Open();
                     
                    conn.Query<House>
                     ($@"delete from house 
                      where house_id = {HouseId} 
                      and creator_broker_id = {_broker.Broker_id}");

                 }

             });


        }



        public House GetHouseById(int id)
        {
            House house;
            using (NpgsqlConnection conn = new NpgsqlConnection(Connection.GetString()))
            {
                conn.Open();
                var h = conn.Query<House>
                       ($"select * from get_full_info_house where house_id = @id", new {id});

                house = h.First();
            }
            return house;
        }

        public House GetByPrice(string price)
        {
            House house;
            using (NpgsqlConnection conn = new NpgsqlConnection(Connection.GetString()))
            {
                conn.Open();
                var h = conn.Query<House>
                       ($"select * from get_full_info_house where house_id =@price",new {price});

                house = h.First();
            }
            return house;
        }
        public IEnumerable<House> GetHouses()
        {
            IEnumerable<House> houses;
            using (NpgsqlConnection conn = new NpgsqlConnection(Connection.GetString()))
            {
                conn.Open();
                houses = conn.Query<House>
                      ($"select * from get_full_info_house");

            }
            return houses;
        }

        public async Task UpdateHouse(House house)
        {


            using (NpgsqlConnection conn = new NpgsqlConnection(Connection.GetString()))
            {

                conn.Open();
                conn.QueryFirstOrDefault(@$"update house set 
                                        area = @area, 
                                        count_room = @count_room,
                                        price = @price,
                                        is_sold = @is_sold
                                        where 
                                        house_id = @house_id
                                        and creator_broker_id = @creator_broker_id", new
                                        {
                                            area = house.Area,
                                            count_room = house.Count_Room,
                                            price = house.Price,
                                            is_sold = house.is_sold,
                                            house_id = house.House_id,
                                            creator_broker_id = _broker.Broker_id
                                        });

            }


        }
    }
}
