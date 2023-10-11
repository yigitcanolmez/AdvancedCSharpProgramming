using System;
namespace SOLID
{
    public interface IDatabaseService
    {
        void Connect();
        void Disconnect();
    }
    public class Database : IDatabaseService
    {
        public void Connect()
        {
            Console.WriteLine("Database bağlan!");
        }
        public void Disconnect()
        {
            Console.WriteLine("Database bağlantısı kopar!");
        }
    }
    public class User
    {
        private readonly IDatabaseService _database;
        public User(IDatabaseService database)
        {
            _database = database;
        }

        public void Login()
        {
            _database.Connect();

            //logic

            _database.Disconnect();

        }

    }
}

