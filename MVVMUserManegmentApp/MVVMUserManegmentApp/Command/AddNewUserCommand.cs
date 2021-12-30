using MVVMUserManegmentApp.Model;
using MVVMUserManegmentApp.View;
using MVVMUserManegmentApp.ViewModel;
using MVVMUserManegmentApp.ViewModel.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace MVVMUserManegmentApp.Command
{
    public class AddNewUserCommand : ICommand
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
        public AddNewUserCommand(UserViewModel vm)
        {
            VM = vm;
        }
        public bool CanExecute(object parameter)
        {            
            return true;
        }
        public void Execute(object parameter)
        {
            User user = new User
            {
                FirstName = VM.User.FirstName,
                LastName = VM.User.LastName,
                Email = VM.User.Email,
                Password = VM.User.Password,
                DOB = VM.User.DOB,
                Gender = VM.User.Gender
            };
            UserManegmentHelper.AddNewUser(user);
            VM = new UserViewModel();
            
        }
    }
}
