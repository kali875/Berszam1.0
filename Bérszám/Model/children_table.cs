using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bérszám.Model
{
    class children_table
    {
        
        public int Customer_ID { get; set; }
        public String Name { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public string Own { get; set; }
        //public DateTime Rest_in_Peace { get; set; }
        public string DurableSick { get; set; }
        public string School { get; set; }
        public children_table(int customer_ID, string name, DateTime date_of_Birth, string own,  string durableSick, string school)
        {
            Customer_ID = customer_ID;
            Name = name;
            Date_of_Birth = date_of_Birth;
            Own = own;
            //Rest_in_Peace = rest_in_Peace;
            DurableSick = durableSick;
            School = school;
        }

    }
}
