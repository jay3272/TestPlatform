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
    public partial class FlowView : Form, IFlowView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public FlowView()
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
            btnStart.Click += delegate { StartEvent?.Invoke(this, EventArgs.Empty); };
            StartEvent += OnStartEvent;
            //Others
        }

        //Properties
        public string Id { get => txtFlowId.Text; set => txtFlowId.Text=value; }
        public string LevelName { get => txtFlowName.Text; set => txtFlowName.Text=value; }
        public string Model { get => txtModel.Text; set => txtModel.Text = value; }
        public string SendCmd { get => txtSendCmd.Text; set => txtSendCmd.Text = value; }
        public string SendValue { get => txtSendCmd.Text; set => txtSendCmd.Text = value; }
        public string ReValue { get => txtSendCmd.Text; set => txtSendCmd.Text = value; }
        public string ReType { get => txtSendCmd.Text; set => txtSendCmd.Text = value; }
        public bool ReTest { get => bool.Parse(txtSendCmd.Text); set => txtSendCmd.Text = value.ToString(); }
        public string Commenet { get => txtSendCmd.Text; set => txtSendCmd.Text = value; }
        //public string SendValue { get => txtSendValue.Text; set => txtSendValue.Text = value; }
        //public string ReValue { get => txtReValue.Text; set => txtReValue.Text = value; }
        //public string ReType { get => txtReType.Text; set => txtReType.Text = value; }
        //public bool ReTest { get => txtSendCmd.Text; set => txtSendCmd.Text = value; }
        //public string Commenet { get => txtCommenet.Text; set => txtCommenet.Text = value; }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler StartEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetFlowListBindingSource(BindingSource flowList)
        {
            dataGridView.DataSource = flowList;
        }

        //Singleton pattern (Open a single form instance)
        private static FlowView instance;
        public static FlowView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FlowView();
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
        
        private void OnStartEvent(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0 || dataGridView.Columns.Count == 0)
            {
                MessageBox.Show("DataGridView 沒有資料！");
                return;
            }

            // 遍歷每一行
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow) // 跳過新增列
                {
                    // 將當前行的所有儲存格設為綠色
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.LightGreen;
                    }

                    MessageBox.Show("Next");

                    // 恢復當前行的背景色為預設值
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
