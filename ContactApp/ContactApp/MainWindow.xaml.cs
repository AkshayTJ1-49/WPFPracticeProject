using ContactApp.Classes;
using SQLite;
using System;
using System.Collections.Generic;
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

namespace ContactApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> contacts;
        public MainWindow()
        {
            InitializeComponent();
            contacts = new List<Contact>();
            ReadDataBase();//as soon as window loads
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewContactWindow contactWindow = new NewContactWindow();
            //contactWindow.Show();
            contactWindow.ShowDialog();
            ReadDataBase();//after closing window
        }
        public void ReadDataBase()
        {
            
            using (SQLiteConnection connection=new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();//this will be ignored if table is already created
                                                  //this is for if there is no table then th app will crash as we are calling read method as sson as Main window is created see line28
                contacts=(connection.Table<Contact>().ToList()).OrderBy(c=>c.Name).ToList();

            }
            listViewBox.ItemsSource = contacts;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searhTextBox=sender as TextBox;
            var filteredList = contacts.Where(c => c.Name.ToLower().Contains(searhTextBox.Text.ToLower())).ToList();
            listViewBox.ItemsSource = filteredList;


        }

        private void listViewBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact selectedContact=(Contact)listViewBox.SelectedItem;
           
            if (listViewBox.SelectedItem!=null)
            {
                ContactDetailsWindow window = new ContactDetailsWindow(selectedContact);
                window.ShowDialog();
                ReadDataBase();
            }
            
        }
    }
}
