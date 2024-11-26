using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestPlatform.Models;
using TestPlatform.Presenters;
using TestPlatform.Repositories;
using TestPlatform.Views;
using System.Configuration;

namespace TestPlatform
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            string sqlConnectionString2 = ConfigurationManager.ConnectionStrings["SqlConnection2"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString,sqlConnectionString2);

            Application.Run((Form)view);
        }
    }
}
