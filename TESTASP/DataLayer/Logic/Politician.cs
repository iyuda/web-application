using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Politician : BasePolitician
    {
       public int YearsInOffice { get; set; }
       public bool isLiberal { get; set; }

    }
}
