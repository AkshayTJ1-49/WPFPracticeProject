using ContactApp.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContactApp.Controls
{
   
    public partial class ContactControl : UserControl
    {
        private Contact contact;

        public Contact Contact
        {
            get { return contact; }
            set
            {
                contact = value;
                nameTextBlock.Text = contact.Name;
                phoneTextBlock.Text = contact.Phone;
                emailTextBlock.Text = contact.Email;

            }
        }
        public static readonly DependencyProperty ContactProperty =DependencyProperty.Register("Contact", typeof(Contact), 
                typeof(ContactControl), 
                new PropertyMetadata(new Contact() { Name = "Name Lastname", Email = "example@domain.com", Phone = "123 1234 1234" }, SetText));

        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ContactControl control = d as ContactControl;

            if (control != null)
            {
                control.nameTextBlock.Text = (e.NewValue as Contact).Name;
                control.emailTextBlock.Text = (e.NewValue as Contact).Email;
                control.phoneTextBlock.Text = (e.NewValue as Contact).Phone;
            }
        }



        public ContactControl()
        {
            InitializeComponent();
        }



    }
}
