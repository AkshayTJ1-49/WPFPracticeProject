using SQLite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserManegmentApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users;
        public MainWindow()
        {
            InitializeComponent();           
            users = new List<User>();
            ReadDataBase();
        }

        private void addUserButton_Click(object sender, RoutedEventArgs e)
        {
            NewUserWindow newUserWindow = new NewUserWindow();
            newUserWindow.ShowDialog();
            ReadDataBase();
        }
        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {         
            var filteredList =users.Where(c => c.FirstName.ToLower().Contains(searchBox.Text.ToLower())).ToList();
            usersListView.ItemsSource = filteredList;           
        }

        public void ReadDataBase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.databasepath))
            {
                connection.CreateTable<User>();//this will be ignored if table is already created                                                 
                users = connection.Table<User>().ToList();
            }
            if (users != null)
            {
                usersListView.ItemsSource = users;
            }
           
        }
       

    }
}
