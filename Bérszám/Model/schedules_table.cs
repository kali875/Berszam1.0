using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bérszám.Model
{
    class schedules_table
    {
        public schedules_table(int iD, int customer_ID, int schedules_WorkTime, DateTime startDate, DateTime endDate, int salary)
        {
            ID = iD;
            Customer_ID = customer_ID;
            Schedules_WorkTime = schedules_WorkTime;
            StartDate = startDate;
            EndDate = endDate;
            Salary = salary;
        }

        public int ID { get; set; }
        public int Customer_ID { get; set; }
        public int Schedules_WorkTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Salary { get; set; }

    }
}
