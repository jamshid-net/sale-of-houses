using Dapper;
using Domain.Core.Models;
using Infrastructure.Data.Commands;
using Infrastructure.Data.Connections;
using Infrastructure.Data.HashMethods;
using Infrastructure.Data.Logins;
using Infrastructure.Data.Registrations;
using Npgsql;
using System.Formats.Asn1;
using System.Globalization;
using UserInterface;

namespace House_sale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartInterface.StartRun();
            Console.ReadKey();
        }
    }
}