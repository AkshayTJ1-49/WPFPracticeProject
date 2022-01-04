using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using MVVMUserManegmentApp.Model;
using System.Windows;
using System.Windows.Input;
using MVVMUserManegmentApp.Command;
using MVVMUserManegmentApp.View;
using System.Collections.ObjectModel;
using MVVMUserManegmentApp.ViewModel.Helper;

namespace MVVMUserManegmentApp.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private string query;
        public string Query
        {
            get { return query; }
            set { query = value; OnPropertyChanged("Query"); }
        }
        private User user = new User();
        public User User
        {
            get { return user; }
            set { user = value; //OnPropertyChanged("User"); 
            }
        }
        public OpenAddUserWindowCommand OpenAddUserWindowCommand { get; set; }
        public AddNewUserCommand AddNewUserCommand { get; set; }
        public SearchCommand SearchCommand { get; set; }
        private ObservableCollection<User> users;
        public ObservableCollection<User> Users
        {
            get { return users; }
            set { users = value; OnPropertyChanged("Users"); }
        }
        public UserViewModel()
        {
            List<User> usersList = UserManegmentHelper.ReadDataBase();
            Users = new ObservableCollection<User>(usersList);
            User = new User();
            OpenAddUserWindowCommand = new OpenAddUserWindowCommand(this);
            AddNewUserCommand = new AddNewUserCommand(this);
            SearchCommand = new SearchCommand(this);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private static UserViewModel _instance = null;
        public static UserViewModel GetUserViewModelinstance()
        {
            if (_instance == null) return new UserViewModel();
            return _instance;
        }
    }
}
