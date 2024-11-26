using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPlatform.Views
{
    public partial class AdtranView : Form, IAdtranView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public AdtranView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Others
        }

        //Properties
        public string Tester { get => txtTester.Text; set => txtTester.Text=value; }
        public string Model { get => txtModel.Text; set => txtModel.Text = value; }
        public string Pcbsn { get => txtPcbsn.Text; set => txtPcbsn.Text = value; }
        public string Saleno { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OLT_to_Lan1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Lan1_to_OLT { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OLT_to_Lan3 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Lan3_to_OLT { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Framelen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Framerate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Testduration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Result { get => txtResult.Text; set => txtResult.Text = value; }
        public string Testtime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Swver { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Ip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Testdate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Note { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }
       
        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetAdtranListBindingSource(BindingSource adtranList)
        {
            dataGridView.DataSource = adtranList;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //Singleton pattern (Open a single form instance)
        private static AdtranView instance;
        public static AdtranView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AdtranView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

    }
}
