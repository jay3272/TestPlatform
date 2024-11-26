using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPlatform.Views
{
    public interface IAdtranView
    {
        //Properties - Fields
        string Tester { get; set; }
        string Model { get; set; }
        string Pcbsn { get; set; }
        string Saleno { get; set; }
        string OLT_to_Lan1 { get; set; }
        string Lan1_to_OLT { get; set; }
        string OLT_to_Lan3 { get; set; }
        string Lan3_to_OLT { get; set; }
        string Framelen { get; set; }
        string Framerate { get; set; }
        string Testduration { get; set; }
        string Result { get; set; }
        string Testtime { get; set; }
        string Swver { get; set; }
        string Ip { get; set; }
        string Testdate { get; set; }
        string Note { get; set; }

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
        void SetAdtranListBindingSource(BindingSource adtranList);
        void Show();
    }
}
