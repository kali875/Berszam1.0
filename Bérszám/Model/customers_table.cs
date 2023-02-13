using Bérszám.Operation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bérszám.Model
{
    class customers_table
    {
        public List<wage_from_table> Wage_Table;
        public List<children_table> Children_Table;
        public List<holiday_table> Holiday_Table;
        public List<married_table> Maried_Table;
        public List<schedules_table> Schedules_Table;
        public List<sick_table> Sick_Table;
        public List<working_time_table> working_time_Table;

        public CalculationSalary CalSalary;
        public customers_table() { }
        public customers_table(int iD, int cardWork_ID, string firstName, string lastName, string identity_Number, string mother_Name, DateTime date_of_Birth, string place_of_Birth, string residence_City, string residence_Street, String residence_Housenumber, int residence_City_number, int distance, int wage_form_ID, string tAJ_Number, int tax_Number, int educational_Attainment_ID, int holiday_Count)
        {
            ID = iD;
            CardWork_ID = cardWork_ID;
            FirstName = firstName;
            LastName = lastName;
            Identity_Number = identity_Number;
            Mother_Name = mother_Name;
            Date_of_Birth = date_of_Birth;
            Place_of_Birth = place_of_Birth;
            Residence_City = residence_City;
            Residence_Street = residence_Street;
            Residence_Housenumber = residence_Housenumber;
            Residence_City_number = residence_City_number;
            Distance = distance;
            Wage_form_ID = wage_form_ID;
            TAJ_Number = tAJ_Number;
            Tax_Number = tax_Number;
            Educational_Attainment_ID = educational_Attainment_ID;
            Holiday_Count = holiday_Count;

            Set_Wage_Table(Wage_form_ID);
            Set_Children_Table(ID);
            Set_Holiday_Table(ID);
            Set_Maried_Table(ID);
            Set_Schedules_Table(ID);
            Set_Sick_Table(ID);
            Set_Working_time_Table(CardWork_ID);
        }
        public int ID { get; set; }
        public int CardWork_ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Identity_Number { get; set; }
        public String Mother_Name { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public String Place_of_Birth { get; set; }
        public String Residence_City { get; set; }
        public String Residence_Street { get; set; }
        public String Residence_Housenumber { get; set; }
        public int Residence_City_number { get; set; }
        public int Distance { get; set; }
        public int Wage_form_ID { get; set; }
        public String TAJ_Number { get; set; }
        public int Tax_Number { get; set; }
        public int Educational_Attainment_ID { get; set; }
        public int Holiday_Count { get; set; }

        void Set_Wage_Table(int ID) 
        {
            this.Wage_Table = new Select<wage_from_table>().Select_querry(ID);
        }
        void Set_Children_Table(int ID)
        {
            this.Children_Table = new Select<children_table>().Select_querry(ID);
        }
        void Set_Holiday_Table(int ID)
        {
            this.Holiday_Table = new Select<holiday_table>().Select_querry(ID);
        }
        void Set_Maried_Table(int ID)
        {
            this.Maried_Table = new Select<married_table>().Select_querry(ID);
        }
        void Set_Schedules_Table(int ID)
        {
            this.Schedules_Table = new Select<schedules_table>().Select_querry(ID);
        }
        void Set_Sick_Table(int ID)
        {
            this.Sick_Table = new Select<sick_table>().Select_querry(ID);
        }
        void Set_Working_time_Table(int ID)
        {
            this.working_time_Table = new Select<working_time_table>().Select_querry(ID);
        }
    }
}
