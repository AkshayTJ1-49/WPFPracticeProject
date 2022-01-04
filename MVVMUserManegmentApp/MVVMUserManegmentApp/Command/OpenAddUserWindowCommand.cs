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
    public class OpenAddUserWindowCommand : ICommand
    {
        public UserViewModel VM;

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
        #region
        public OpenAddUserWindowCommand(UserViewModel vm)
        {
            VM = vm;
        }
        #endregion

        public bool CanExecute(object parameter)
        {
            return true;
        }        
        public void Execute(object parameter)
        {
            NewUserWindow newUserWindow = new NewUserWindow();
            newUserWindow.ShowDialog();
            VM.Users = new ObservableCollection<User>(UserManegmentHelper.ReadDataBase());
        }
    }
}
