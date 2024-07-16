using System;
using System.Collections.Generic;

namespace UserAccountManagement
{
    public class User
    {
        // Assign and Return the User Data
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }
    }

    class UserAccountManager
    {
        //Store the Input
        private static List<User> users = new List<User>();

        public static void AddUser(int id, string username, string password)
        {
            users.Add(new User(id, username, password));
        }
        public static void DisplayUsers()
        {
            //Display the Account
            foreach (var user in users)
            {
                Console.WriteLine($"Id: {user.Id}, Username: {user.Username}, Password: {user.Password}");
            }
        }
    }
}