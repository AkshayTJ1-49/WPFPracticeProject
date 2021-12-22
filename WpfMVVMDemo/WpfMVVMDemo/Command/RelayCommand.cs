using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WpfMVVMDemo.Command
{
    public class RelayCommand : ICommand
    {
        Action<Object> executeAction;
        Func<Object, bool> canExecute;
        bool canExecuteCache;
        public RelayCommand(Action<Object> executeAction, Func<Object, bool> canExecute,bool canExecuteCache)
        {
            this.executeAction = executeAction;
            this.canExecute = canExecute;
            this.canExecuteCache = canExecuteCache;
        }

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

        public bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;
            }
            else
            {
                return canExecute(parameter);
            }
        }

        public void Execute(object parameter)
        {
            executeAction(parameter);
        }
       

    }
}
