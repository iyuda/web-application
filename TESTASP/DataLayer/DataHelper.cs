using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataHelper
    {
        public List<Politician> getPoliticians()
        {
            List<Politician> lstJ = new List<Politician>();

            Politician j1 = new Politician
            {
                FirstName = "Bill",
                LastName = "Clinton",
                YearsInOffice = 8,
                JobTitle = "President",
                isLiberal = true
            };

            Politician j2 = new Politician
            {
                FirstName = "Hillary",
                LastName = "Clinton",
                YearsInOffice = 0,
                JobTitle = "Secretary of State",
                isLiberal = true
            };

            Politician j3 = new Politician
            {
                FirstName = "Donald",
                LastName = "Trump",
                YearsInOffice = 0,
                JobTitle = "Entertaiment Mogul",
                isLiberal = false
            };

            Politician j4 = new Politician
            {
                FirstName = "Barak",
                LastName = "Obama",
                YearsInOffice = 8,
                JobTitle = "Asshole",
                isLiberal = true
            };

            Politician j5 = new Politician();

            j5.FirstName = "Ted";
            j5.LastName = "Cruz";
            j5.YearsInOffice = 0;
            j5.JobTitle = "Congressman";
            j5.isLiberal = false;

            lstJ.Add(j1);
            lstJ.Add(j2);
            lstJ.Add(j3);
            lstJ.Add(j4);
            lstJ.Add(j5);

            return lstJ;
        }
    }
}
