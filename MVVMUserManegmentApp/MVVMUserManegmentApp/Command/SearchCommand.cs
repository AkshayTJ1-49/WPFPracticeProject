using MVVMUserManegmentApp.Model;
using MVVMUserManegmentApp.ViewModel;
using MVVMUserManegmentApp.ViewModel.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace MVVMUserManegmentApp.Command
{
    public class SearchCommand : ICommand
    {
        public UserViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
        public SearchCommand(UserViewModel vm)
        {
            VM = vm;
        }
       
        public bool CanExecute(object parameter)
        {            
            return true;
        }
        public void Execute(object parameter)
        {
            List<User> filteredUsers = UserManegmentHelper.Search(VM.Query);
            VM.Users = new ObservableCollection<User>(filteredUsers);
        }
    }
}
