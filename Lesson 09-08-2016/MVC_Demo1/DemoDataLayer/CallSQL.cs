using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoDataLayer
{
    public class CallSQL
    {
        public static List<StateInfo>GetAllStates()
        {
            List<StateInfo> lst = new List<StateInfo>();
            DataTable tbl = DataHelper.GetTableExecuted("[Person].StateProvince");
            StateInfo state;

            foreach(DataRow dr in tbl.Rows)
            {
                state = new StateInfo();
                state.StateCode = dr["StateProvinceCode"].ToString();
                state.StateName = dr["Name"].ToString();
                state.CountryCode = dr["CountryRegionCode"].ToString();

                lst.Add(state);
            }
            return lst;
        }

        public static List<PersonInfo> GetAllPersons()
        {
            List<PersonInfo> lst = new List<PersonInfo>();
            PersonInfo p;

            DataTable tbl = DataHelper.GetTableExecuted("ComplexPersonView");
            foreach(DataRow dr in tbl.Rows)
            {
                p = new PersonInfo();
                p.ID = Convert.ToInt32(dr["BusinessEntityID"].ToString());
                p.FullName = GetFullName(dr);
                p.Address1 = dr["AddressLine1"].ToString();
                p.Address2 = dr["AddressLine2"].ToString();
                p.City = dr["City"].ToString();
                p.State = dr["StateProvinceCode"].ToString();
                p.Zip = dr["PostalCode"].ToString();
                p.Phone = dr["PhoneNumber"].ToString();

                lst.Add(p);
            }

            return lst;
        }

        #region Private Help

        private static string GetFullName(DataRow row)
        {
            string _name = string.Empty;

            if(string.IsNullOrWhiteSpace(row["Title"].ToString()))
            {
                _name = row["Title"].ToString().Trim() + " " + row["FirstName"].ToString().Trim() + " " + row["LastName"].ToString();
            }
            else
            {
                _name = row["FirstName"].ToString().Trim() + " " + row["LastName"].ToString();
            }

            return _name;
        }

        #endregion

    }
}
