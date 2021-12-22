using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WpfMVVMDemo.Model
{
    public class Person : INotifyPropertyChanged, IDataErrorInfo
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                // OnPropertyChanged(FirstName);
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                // OnPropertyChanged(LastName);
            }
        }

        private string fullName;

        public string FullName
        {
            get { return fullName = FirstName + " " + LastName; }
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                    //OnPropertyChanged(FullName);
                }
            }
        }
        //For converter
        public DateTime Date { get; set; }

        #region ForValidation 
        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string propertyName]
        {
            get
            {
                string result = string.Empty;
                switch (propertyName)
                {
                    case "FirstName":
                        {
                            result = "Firstname required";
                            break;
                        }
                    case "LastName":
                        {
                            result = "Lastname required";
                            break;
                        }
                }
                return result;
            }

        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string paramter)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            this.PropertyChanged(this, new PropertyChangedEventArgs(paramter));
        }
    }
}
