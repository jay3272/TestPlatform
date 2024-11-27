using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TestPlatform.Models
{
    public class FlowModel
    {
        //Fields
        private int id;
        private string levelName;
        private string model;
        private string sendCmd;
        private string sendValue;
        private string reValue;
        private string reType;
        private bool reTest;
        private string commenet;

        //Properties - Validations
        [DisplayName("ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("LevelName")]
        public string LevelName { get => levelName; set => levelName = value; }

        [DisplayName("Model")]
        public string Model { get => model; set => model = value; }

        [DisplayName("SendCmd")]
        public string SendCmd { get => sendCmd; set => sendCmd = value; }

        [DisplayName("SendValue")]
        public string SendValue { get => sendValue; set => sendValue = value; }

        [DisplayName("ReValue")]
        public string ReValue { get => reValue; set => reValue = value; }

        [DisplayName("ReType")]
        public string ReType { get => reType; set => reType = value; }

        [DisplayName("ReTest")]
        public bool ReTest { get => reTest; set => reTest = value; }

        [DisplayName("Commenet")]
        public string Commenet { get => commenet; set => commenet = value; }

    }
}
