using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace UserManegmentApp
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
