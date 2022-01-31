using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SQLite;

namespace MVVMUserManegmentApp.Model
{
    public class User : IDataErrorInfo, INotifyPropertyChanged
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private DateTime dob;

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Dictionary<string, string> ErrorCollection { get; private set; } = new Dictionary<string, string>();

        public string Error { get { return null; } }

        public string this[string propertyName]
        {
            get
            {
                string result = string.Empty;
                switch (propertyName)
                {
                    case "FirstName":
                        {
                            if (string.IsNullOrEmpty(FirstName))
                                result = "Firstname is required";
                            else if (FirstName.Length < 2)
                                result = "Length must be more then two";

                            break;
                        }
                    case "LastName":
                        {
                            if (string.IsNullOrEmpty(LastName))
                                result = "Lastname is required";
                            else if (LastName.Length < 2)
                                result = "Length must be more then two";
                            break;
                        }
                    case "Email":
                        {
                            if (string.IsNullOrEmpty(Email))
                                result = "Email is required";
                            else if(!(Email.EndsWith("@gmail.com"))) 
                                result = "Email is invalid";
                            break;
                        }
                    case "Password":
                        {
                            if (string.IsNullOrEmpty(Password))
                                result = "Password is required";
                            break;
                        }                      
                }
                if (ErrorCollection.ContainsKey(propertyName))
                {
                    ErrorCollection[propertyName] = result;
                }
                else if (result != null)
                {
                    ErrorCollection.Add(propertyName, result);
                }
                OnPropertyChanged("ErrorCollection");
                return result;

            }

        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }


    }
}
