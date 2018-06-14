using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPart1.Models
{
    public class Introduction
    {
        public string TitleName { get; set; }
        public string MyDate
        {
            get { return DateTime.Today.ToString("MM/dd/yyyy"); }
        }
    }
}
