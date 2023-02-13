using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bérszám.Model
{
    class sick_table
    {
        public sick_table(int customer_ID, DateTime start_Sick, DateTime end_Sick)
        {
            Customer_ID = customer_ID;
            Start_Sick = start_Sick;
            End_Sick = end_Sick;
        }

       public int Customer_ID { get; set; }
        public DateTime Start_Sick { get; set; }
        public DateTime End_Sick { get; set; }
    }
}
