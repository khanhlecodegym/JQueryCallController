using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAjaxCallController.Models
{
    public class Codegymer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public bool IsNam { get; set; }
        public bool IsDepTrai { get; set; }
        public bool IsGiau { get; set; }
        public bool IsThongMinh { get; set; }

        public Codegymer()
        {
            IsDepTrai = false;
            IsGiau = false;
            IsThongMinh = false;
        }
    }
}
