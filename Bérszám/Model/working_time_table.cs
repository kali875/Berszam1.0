using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bérszám.Model
{
    class working_time_table
    {
        public working_time_table(int iD, int cardWork_ID, DateTime start_Work, DateTime end_Work, int count)
        {
            ID = iD;
            CardWork_ID = cardWork_ID;
            Start_Work = start_Work;
            End_Work = end_Work;
            Count = count;
        }

        public int ID { get; set; }
        public int CardWork_ID { get; set; } 
        public DateTime Start_Work { get; set; }
        public DateTime End_Work { get; set; }

        public int Count { get; set; }
    }
}
