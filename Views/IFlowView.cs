using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPlatform.Views
{
    public interface IFlowView
    {
        //Properties - Fields
        string Id { get; set; }
        string LevelName { get; set; }
        string Model { get; set; }
        string SendCmd { get; set; }
        string SendValue { get; set; }
        string ReValue { get; set; }
        string ReType { get; set; }
        bool ReTest { get; set; }
        string Commenet { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetFlowListBindingSource(BindingSource flowList);
        void Show();
    }
}
