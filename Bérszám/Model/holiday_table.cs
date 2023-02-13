using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bérszám.Model
{
    class holiday_table
    {
        public holiday_table(int customer_ID, DateTime start_Holiday, DateTime end_Holiday)
        {
            Customer_ID = customer_ID;
            Start_Holiday = start_Holiday;
            End_Holiday = end_Holiday;
        }

        public int Customer_ID { get; set; }
        public DateTime Start_Holiday { get; set; }
        public DateTime End_Holiday { get; set; }
    }
}
