using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using DemoDataLayer;

namespace MVC_Demo1.Models
{
    public class PersonModel
    {
        public List<SelectListItem> getComboStateList
        {
            get
            {
                List<SelectListItem> lst = new List<SelectListItem>();
                foreach (StateInfo state in CallSQL.GetAllStates())
                {
                    lst.Add(new SelectListItem { Text = state.ToString(), Value = state.StateCode });
                }

                return lst;
            }

        }

        public List<PersonInfo> lstPersons { get; set; }
        
        public string StateParam { get; set; }

        public void ListAllPersons()
        {
            if (!string.IsNullOrWhiteSpace(this.StateParam))
            {
                var allPersons = CallSQL.GetAllPersons();

                this.lstPersons = (from p in allPersons
                       where p.State == this.StateParam
                       select p).Take(500).ToList();
            }
            else
            {
                this.lstPersons = new List<PersonInfo>();
            }
        }

        public string TotalRecords { get; set; }
    }
}
