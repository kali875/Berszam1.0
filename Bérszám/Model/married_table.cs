using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bérszám.Model
{
    class married_table
    {
        public married_table(int customer_ID, string name, DateTime start_Maried_Date)
        {
            Customer_ID = customer_ID;
            Name = name;
            Start_Maried_Date = start_Maried_Date;
        }

        public int Customer_ID { get; set; }
        public string Name { get; set; }
        public DateTime Start_Maried_Date { get; set; }
    }
}
