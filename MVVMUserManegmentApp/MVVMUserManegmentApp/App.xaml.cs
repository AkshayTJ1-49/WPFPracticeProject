using System;
using System.Windows;

namespace MVVMUserManegmentApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string databasename = "Users.db";
        static string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
        public static string databasepath = System.IO.Path.Combine(databasename, folderpath);


    }
}
