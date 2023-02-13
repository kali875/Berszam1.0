using Bérszám.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bérszám.Operation
{

    class CalculationSalary
    {
        private customers_table customers;
        private List<Task> Tasks;
        public CalculationSalary(customers_table obj) 
        {
            this.customers = obj;
            StartDay = new DateTime(2022,9,1);
            EndDay = new DateTime(2022, 9, 30);
            
            Calculation();
        }
        public CalculationSalary()
        {

        }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }    
        public int MonthWorkDays { get; set; }
        public int Divisor { get; set; }
        public double CustomerWorkHours { get; set; }
        public double BaseSalary { get; set; }       
        public double CurrentSalary { get; set; }
        public int Count { get; set; }
        public void Calculation() 
        {
            if (customers.Wage_form_ID == 3)
            {
                FixSalaryCalculation();
            }
            else if (customers.Wage_form_ID == 4) 
            {
                MonthlySalaryCalculation();
            }
            else if (customers.Wage_form_ID == 5)
            {
                HoursSalaryCalculation();
            }
            else if (customers.Wage_form_ID == 6)
            {
                PerformanceSalaryCalculation();
            }
        }
        private void MonthlySalaryCalculation() 
        {
            MonthlyMonthWorkDaysCalculation();
            MonthlyDivisorCalculation();
            MonthlyCustomerWorkHoursCalculation();
            MonthlyBaseSalaryCalculation();
            MonthlyCurrentSalaryCalculation();
        }
        private void FixSalaryCalculation()
        {
            MonthlyMonthWorkDaysCalculation();
            MonthlyCustomerWorkHoursCalculation();
            FixedBaseSalaryCalculation();
            FixCurrentSalaryCalculation();
        }
        private void HoursSalaryCalculation()
        {
            MonthlyMonthWorkDaysCalculation();
            MonthlyCustomerWorkHoursCalculation();
            HoursCurrentSalaryCalculation();
        }
        private void PerformanceSalaryCalculation()
        {
            MonthlyMonthWorkDaysCalculation();
            PerformanceCountCalculation();
            PerformanceCurrentSalaryCalculation();
        }
        //MonthlySalaryCalculation
        private void MonthlyMonthWorkDaysCalculation() 
        {
            int days = 0;
            for (DateTime date = StartDay; date <= EndDay; date = date.AddDays(1))
            {
                if (StartDay.DayOfWeek != DayOfWeek.Saturday && StartDay.DayOfWeek != DayOfWeek.Sunday) 
                {
                    days++;
                }
                StartDay = StartDay.AddDays(1);
            }

            MonthWorkDays = days;
        }
        private void MonthlyDivisorCalculation()
        {
            foreach (var item in customers.Schedules_Table)
            {
                Divisor = MonthWorkDays* item.Schedules_WorkTime;
            }           
        }
        private void MonthlyBaseSalaryCalculation()
        {
            foreach (var item in customers.Schedules_Table)
            {
                BaseSalary = item.Salary / Divisor;
            }
        }
        private void MonthlyCustomerWorkHoursCalculation() 
        {
            double hours= 0;

            foreach (var item in customers.working_time_Table)
            {
                hours += (item.End_Work - item.Start_Work).TotalHours;          
            }

            CustomerWorkHours = hours;
        }
        private void MonthlyCurrentSalaryCalculation()
        {
            CurrentSalary = BaseSalary * CustomerWorkHours;
        }
        //FixSalaryCalculation
        private void FixedBaseSalaryCalculation()
        {
            foreach (var item in customers.Schedules_Table)
            {
                BaseSalary = item.Salary;
            }
        }
        private void FixCurrentSalaryCalculation()
        {
            CurrentSalary = BaseSalary;
        }
        //HoursSalaryCalculation
        private void HoursCurrentSalaryCalculation()
        {
            foreach (var item in customers.Schedules_Table)
            {
                CurrentSalary = item.Salary * CustomerWorkHours;
            }          
        }
        //PerformanceSalaryCalculation
        private void PerformanceCountCalculation()
        {
            int count = 0;
            foreach (var item in customers.working_time_Table)
            {
                count += item.Count;
            }
            Count = count;
        }
        private void PerformanceCurrentSalaryCalculation()
        {
            foreach (var item in customers.Schedules_Table)
            {
                CurrentSalary = item.Salary * Count;
            }
            
        }
    }
}
