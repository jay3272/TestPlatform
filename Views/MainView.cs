using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using TestPlatform.Models.SQLite;

namespace TestPlatform.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnPets.Click += delegate { ShowPetView?.Invoke(this, EventArgs.Empty); };
            btnAdtran.Click += delegate { ShowAdtranView?.Invoke(this, EventArgs.Empty); };
            btnFlow.Click += delegate { ShowFlowView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowPetView;
        public event EventHandler ShowAdtranView;
        public event EventHandler ShowFlowView;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowVetsView;

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Test SQLite
            PublicVar.connSqlDb = PublicMethod.ConnectSqlite("mydatabase.db");
            PublicVar.connSqlDb.Open();
            PublicVar.connSqlDb.Execute("CREATE TABLE IF NOT EXISTS TestModel (Id INTEGER PRIMARY KEY, Name TEXT)");
            PublicVar.connSqlDb.Execute("INSERT INTO TestModel (Name) VALUES (@Name)", new { Name = "Alice" });

            var tests = PublicVar.connSqlDb.Query<TestModel>("SELECT * FROM TestModel");
            foreach (var test in tests)
            {
                MessageBox.Show($"ID: {test.Id}, Name: {test.Name}");
            }

        }

    }
}
