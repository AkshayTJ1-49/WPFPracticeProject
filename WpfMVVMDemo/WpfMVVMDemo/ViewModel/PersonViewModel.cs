using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using WpfMVVMDemo.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfMVVMDemo.Command;

namespace WpfMVVMDemo.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person _person;
        public Person Person
        {
            get { return _person; }
            set { 
                    _person = value; NotifyPropertyChanged("Person");             
            }
        }
        public PersonViewModel()
        {
            _person = new Person();
            persons = new ObservableCollection<Person>();
        }

        private ObservableCollection<Person> persons;
        public ObservableCollection<Person> Persons
        {
            get { return persons; }
            set { persons = value;
                NotifyPropertyChanged("Persons");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string parameter)
        {
            if (parameter != null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(parameter));
            }
          
        }

        private ICommand _submitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if (_submitCommand == null)
                {
                    _submitCommand = new RelayCommand(submitExecute,CanSubmit,false);
                }
                return _submitCommand;
            }
        }

        private bool CanSubmit(object parameter)
        {
            if (string.IsNullOrEmpty(Person.FirstName)|| string.IsNullOrEmpty(Person.LastName))
            {
                return false;
            }
            else
            {
                return true;   
            }
        }
        private void submitExecute(object parameter)
        {
            persons.Add(Person);
        }
    }
}
