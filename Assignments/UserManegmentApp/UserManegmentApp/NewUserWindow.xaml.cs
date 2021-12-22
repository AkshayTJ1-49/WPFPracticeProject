using SQLite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UserManegmentApp
{
    /// <summary>
    /// Interaction logic for NewUserWindow.xaml
    /// </summary>
    public partial class NewUserWindow : Window
    {
        User newUser { get; set; }
        public NewUserWindow()
        {
            InitializeComponent();         
            
        }

        private void addUserButton_Click(object sender, RoutedEventArgs e)
        {
            string gender= string.Empty;
            DateTime selectedDate = (DateTime)dateOfBirth.SelectedDate;                   

            if (maleRadioBtn.IsChecked==true)
            {
                gender = "Male";
            }
            else if(femaleRadioBtn.IsChecked==true)
            {
                gender = "Female";
            }

            if (!(string.IsNullOrEmpty(firstNameTxtBox.Text) && string.IsNullOrEmpty(lastNameTxtBox.Text) && string.IsNullOrEmpty(emailTxtBox.Text)))
            {
                newUser = new User
                {
                    FirstName = firstNameTxtBox.Text,
                    LastName = lastNameTxtBox.Text,
                    Email = emailTxtBox.Text,
                    Password = passwordTxtBox.Text,
                    Gender = gender,
                    DOB = selectedDate
                };
            }

            using (SQLiteConnection connection = new SQLiteConnection(App.databasepath))
            {
                connection.CreateTable<User>();
                connection.Insert(newUser);
            }         
            Close();            
           
        }
       


    }
}
