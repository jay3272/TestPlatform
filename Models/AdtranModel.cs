using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TestPlatform.Models
{
    public class AdtranModel
    {
        //Fields
        private string tester;
        private string model;
        private string pcbsn;
        private string saleno;
        private string oLT_to_Lan1;
        private string lan1_to_OLT;
        private string oLT_to_Lan3;
        private string lan3_to_OLT;
        private string framelen;
        private string framerate;
        private string testduration;
        private string result;
        private string testtime;
        private string swver;
        private string ip;
        private DateTime testdate;
        private string note;

        //Properties - Validations
        [DisplayName("Tester")]
        public string Tester { get => tester; set => tester = value; }

        [DisplayName("Model")]
        public string Model { get => model; set => model = value; }

        [DisplayName("Pcbsn")]
        public string Pcbsn { get => pcbsn; set => pcbsn = value; }

        [DisplayName("Saleno")]
        public string Saleno { get => saleno; set => saleno = value; }

        [DisplayName("OLT_to_Lan1")]
        public string OLT_to_Lan1 { get => oLT_to_Lan1; set => oLT_to_Lan1 = value; }

        [DisplayName("Lan1_to_OLT")]
        public string Lan1_to_OLT { get => lan1_to_OLT; set => lan1_to_OLT = value; }

        [DisplayName("OLT_to_Lan3")]
        public string OLT_to_Lan3 { get => oLT_to_Lan3; set => oLT_to_Lan3 = value; }

        [DisplayName("Lan3_to_OLT")]
        public string Lan3_to_OLT { get => lan3_to_OLT; set => lan3_to_OLT = value; }

        [DisplayName("Framelen")]
        public string Framelen { get => framelen; set => framelen = value; }

        [DisplayName("Framerate")]
        public string Framerate { get => framerate; set => framerate = value; }

        [DisplayName("Testduration")]
        public string Testduration { get => testduration; set => testduration = value; }

        [DisplayName("Result")]
        public string Result { get => result; set => result = value; }

        [DisplayName("Testtime")]
        public string Testtime { get => testtime; set => testtime = value; }

        [DisplayName("Swver")]
        public string Swver { get => swver; set => swver = value; }

        [DisplayName("Ip")]
        public string Ip { get => ip; set => ip = value; }

        [DisplayName("Testdate")]
        public DateTime Testdate { get => testdate; set => testdate = value; }

        [DisplayName("Note")]
        public string Note { get => note; set => note = value; }

    }
}
