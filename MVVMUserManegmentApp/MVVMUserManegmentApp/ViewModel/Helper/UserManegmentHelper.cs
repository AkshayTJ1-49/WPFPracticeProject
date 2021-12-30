using System;
using System.Collections.Generic;
using System.Text;
using MVVMUserManegmentApp.Model;
using SQLite;
using System.Linq;
using System.Collections.ObjectModel;
using MVVMUserManegmentApp.ViewModel;


namespace MVVMUserManegmentApp.ViewModel.Helper
{
    public class UserManegmentHelper
    {
        public static List<User> ReadDataBase()
        {
            List<User> users = new List<User>();
            using (SQLiteConnection connection = new SQLiteConnection(App.databasepath))
            {
                connection.CreateTable<User>();
                users = connection.Table<User>().ToList();
            }
            return users;
        }
        public static void AddNewUser(User newUser)
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.databasepath))
            {
                connection.CreateTable<User>();
                connection.Insert(newUser);
            }
        }
        public static List<User> Search(string query)
        {
            List<User> users = new List<User>();
            using (SQLiteConnection connection = new SQLiteConnection(App.databasepath))
            {
                connection.CreateTable<User>();
                users = connection.Table<User>().ToList();
            }
            return users.Where(c => c.FirstName.ToLower().Contains(query.ToLower())).ToList();
        }
    }
}
