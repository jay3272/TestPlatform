using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlatform.Models.SQLite
{
    public class TestModel
    {
        //Fields
        private int id;
        private string name;

        //Properties - Validations
        [DisplayName("Test ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Test Name")]
        [Required(ErrorMessage = "Test name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Test name must be between 1 and 50 characters")]
        public string Name { get => name; set => name = value; }

    }
}
