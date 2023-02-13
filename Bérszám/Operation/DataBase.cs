using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Bérszám.Model;
using Bérszám.Properties;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Utilities.Collections;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Bérszám.Operation
{
    // Delete,Update operation missing 
    class DataBase
    {
        protected MySqlConnection Connection;
        protected MySqlCommand Command;
        protected MySqlDataReader Reader;
        protected List<String> TableNames = new List<string>();
        protected List<DataTable> DataTables = new List<DataTable>();
        protected string TableName { get; set; }
        public DataBase() 
        {
            this.Connection = new MySqlConnection($@"SERVER={Settings.Default.ServerName}; DATABASE={Settings.Default.DataBase};UID={Settings.Default.UserName};PASSWORD={Settings.Default.Password};");
            Connection.Open();
            DataBase_TableList();
            Table_RowList();
        }
        ~DataBase()
        {
            Connection.Close();
        }
        private void DataBase_TableList() 
        {
            string query = "show tables from calculating_salary";
            Command = new MySqlCommand(query, Connection);
            using (MySqlDataReader reader = Command.ExecuteReader())
            {
                while (reader.Read())
                {
                    TableNames.Add(reader.GetString(0));
                }
            }
        }
        private void Table_RowList()
        { 
            DataTable Table = new DataTable();
            foreach (var Tablename in TableNames)
            {
                using (var schemaCommand = new MySqlCommand(@$"SELECT * FROM {Tablename}", Connection))
                {
                    using (var reader = schemaCommand.ExecuteReader(CommandBehavior.SchemaOnly))
                    {
                        Table = reader.GetSchemaTable();
                    }
                }
                DataTables.Add(Table);
            }
        }
        protected string Table_RowName(string TableName) 
        {
            string columns = "(";
            int idx = 0;
            foreach (DataTable Table in DataTables)
             {
                foreach (DataRow item in Table.Rows)
                {
                    if (item[10].ToString() == TableName) 
                    {
                        if (idx == 0)
                        {
                            columns += @$"{item[0].ToString()}";
                            idx++;
                        }
                        else
                        {
                            columns += @$",{item[0].ToString()}";
                        }
                    }              
                }
             }
            return columns += ") values";
        }
    }
    class Select<T> : DataBase
    {
        string query { get; set; }
        Type Type = typeof(T);
        bool const_query { get; set; }
        public Select()
        {
            this.query = $@"select * from {Type.Name}";
            const_query = false;
        }
        public Select(string query)
        {
            this.query = $@" select * from {Type.Name} WHERE {query}";
            const_query = true;
        }
        public List<T> Select_querry()
        {
            List<T> list = new List<T>();
            Command = new MySqlCommand(query, Connection);
            if (Type.Name == "customers_table") 
            {
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new customers_table(Convert.ToInt32(Reader["ID"]), Convert.ToInt32(Reader["CardWork_ID"]), Reader["FirstName"].ToString(),
                        Reader["LastName"].ToString(), Reader["Identity_Number"].ToString(), Reader["Mother_Name"].ToString(), DateTime.Parse(Reader["Date_of_Birth"].ToString()),
                        Reader["Place_of_Birth"].ToString(), Reader["Residence_City"].ToString(), Reader["Residence_Street"].ToString(), (Reader["Residence_Housenumber"].ToString()),
                        Convert.ToInt32(Reader["Residence_City_number"]), Convert.ToInt32(Reader["Distance"]), Convert.ToInt32(Reader["Wage_form_ID"]), Reader["TAJ_Number"].ToString(),
                        Convert.ToInt32(Reader["Tax_Number"]), Convert.ToInt32(Reader["Educational_Attainment_ID"]), Convert.ToInt32(Reader["Holiday_Count"])), typeof(T)));
                }               
            }
            if (Type.Name == "wage_from_table")
            {
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new wage_from_table(Convert.ToInt32(Reader["Wage_ID"]), Reader["Name"].ToString()), typeof(T)));
                }
            }
            if (Type.Name == "children_table")
            {
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    //, DateTime.Parse(Reader["Rest_in_Peace"].ToString()),
                    list.Add((T)Convert.ChangeType(new children_table(Convert.ToInt32(Reader["Customer_ID"]), Reader["Name"].ToString(), DateTime.Parse(Reader["Date_of_Birth"].ToString()),Reader["Own"].ToString(), Reader["DurableSick"].ToString(), Reader["School"].ToString()), typeof(T)));
                }
            }
            if (Type.Name == "holiday_table")
            {
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new holiday_table(Convert.ToInt32(Reader["Customer_ID"]), DateTime.Parse(Reader["Start_Holiday"].ToString()), DateTime.Parse(Reader["End_Holiday"].ToString())), typeof(T)));
                }
            }
            if (Type.Name == "married_table")
            {
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new married_table(Convert.ToInt32(Reader["Customer_ID"]), Reader["Name"].ToString(), DateTime.Parse(Reader["Start_Maried_Date"].ToString())), typeof(T)));
                }
            }
            if (Type.Name == "schedules_table")
            {
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new schedules_table(Convert.ToInt32(Reader["ID"]), Convert.ToInt32(Reader["Customer_ID"]), Convert.ToInt32(Reader["Schedules_WorkTime"]), DateTime.Parse(Reader["StartDate"].ToString()), DateTime.Parse(Reader["EndDate"].ToString()), Convert.ToInt32(Reader["Salary"])), typeof(T)));
                }
            }
            if (Type.Name == "sick_table")
            {
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new sick_table(Convert.ToInt32(Reader["Customer_ID"]), DateTime.Parse(Reader["Start_Sick"].ToString()), DateTime.Parse(Reader["End_Sick"].ToString())), typeof(T)));
                }
            }
            if (Type.Name == "working_time_table")
            {
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new working_time_table(Convert.ToInt32(Reader["ID"]), Convert.ToInt32(Reader["CardWork_ID"]), DateTime.Parse(Reader["Start_Work"].ToString()), DateTime.Parse(Reader["End_Work"].ToString()), Convert.ToInt32(Reader["Count"])), typeof(T)));
                }
            }
            
            return list;
        }
        public List<T> Select_querry(int ID)
        {
            List<T> list = new List<T>();

            if (Type.Name == "Customers")
            {
                if (const_query)
                {
                       this.query += $" AND ID = {ID}";
                }
                else { this.query += $" WHERE ID = {ID}"; }
                
                Command = new MySqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new customers_table(Convert.ToInt32(Reader["ID"]), Convert.ToInt32(Reader["CardWork_ID"]), Reader["FirstName"].ToString(),
                        Reader["LastName"].ToString(), Reader["Identity_Number"].ToString(), Reader["Mother_Name"].ToString(), DateTime.Parse(Reader["Date_of_Birth"].ToString()),
                        Reader["Place_of_Birth"].ToString(), Reader["Residence_City"].ToString(), Reader["Residence_Street"].ToString(), (Reader["Residence_Housenumber"].ToString()),
                        Convert.ToInt32(Reader["Residence_City_number"]), Convert.ToInt32(Reader["Distance"]), Convert.ToInt32(Reader["Wage_form_ID"]), Reader["TAJ_Number"].ToString(),
                        Convert.ToInt32(Reader["Tax_Number"]), Convert.ToInt32(Reader["Educational_Attainment_ID"]), Convert.ToInt32(Reader["Holiday_Count"])), typeof(T)));
                }
            }
            if (Type.Name == "wage_from_table")
            {
                if (const_query)
                {
                       this.query += $" AND Wage_ID = {ID}";
                }
                else { this.query += $" WHERE Wage_ID = {ID}"; }
                
                Command = new MySqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new wage_from_table(Convert.ToInt32(Reader["Wage_ID"]), Reader["Name"].ToString()), typeof(T)));
                }
            }
            if (Type.Name == "children_table")
            {
                if (const_query)
                {
                    this.query += $" AND Customer_ID = {ID}";
                }
                else { this.query += $" WHERE Customer_ID = {ID}"; }

                Command = new MySqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    //DateTime.Parse(Reader["Rest_in_Peace"].ToString()), 
                    list.Add((T)Convert.ChangeType(new children_table(Convert.ToInt32(Reader["Customer_ID"]), Reader["Name"].ToString(), DateTime.Parse(Reader["Date_of_Birth"].ToString()), Reader["Own"].ToString(), Reader["DurableSick"].ToString(), Reader["School"].ToString()), typeof(T)));
                }
            }
            if (Type.Name == "holiday_table")
            {
                if (const_query)
                {
                    this.query += $" AND Customer_ID = {ID}";
                }
                else { this.query += $" WHERE Customer_ID = {ID}"; }

                Command = new MySqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new holiday_table(Convert.ToInt32(Reader["Customer_ID"]), DateTime.Parse(Reader["Start_Holiday"].ToString()), DateTime.Parse(Reader["End_Holiday"].ToString())), typeof(T)));
                }
            }
            if (Type.Name == "married_table")
            {
                if (const_query)
                {
                    this.query += $" AND Customer_ID = {ID}";
                }
                else { this.query += $" WHERE Customer_ID = {ID}"; }

                Command = new MySqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new married_table(Convert.ToInt32(Reader["Customer_ID"]), Reader["Name"].ToString(), DateTime.Parse(Reader["Start_Maried_Date"].ToString())), typeof(T)));
                }
            }
            if (Type.Name == "schedules_table")
            {
                if (const_query)
                {
                    this.query += $" AND Customer_ID = {ID}";
                }
                else { this.query += $" WHERE Customer_ID = {ID}"; }

                Command = new MySqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new schedules_table(Convert.ToInt32(Reader["ID"]), Convert.ToInt32(Reader["Customer_ID"]), Convert.ToInt32(Reader["Schedules_WorkTime"]), DateTime.Parse(Reader["StartDate"].ToString()), DateTime.Parse(Reader["EndDate"].ToString()), Convert.ToInt32(Reader["Salary"])), typeof(T)));
                }
            }
            if (Type.Name == "sick_table")
            {
                if (const_query)
                {
                    this.query += $" AND Customer_ID = {ID}";
                }
                else { this.query += $" WHERE Customer_ID = {ID}"; }

                Command = new MySqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new sick_table(Convert.ToInt32(Reader["Customer_ID"]), DateTime.Parse(Reader["Start_Sick"].ToString()), DateTime.Parse(Reader["End_Sick"].ToString())), typeof(T)));
                }
            }
            if (Type.Name == "working_time_table")
            {
                if (const_query)
                {
                    this.query += $" AND CardWork_ID = {ID}";
                }
                else { this.query += $" WHERE CardWork_ID = {ID}"; }

                Command = new MySqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add((T)Convert.ChangeType(new working_time_table(Convert.ToInt32(Reader["ID"]), Convert.ToInt32(Reader["CardWork_ID"]), DateTime.Parse(Reader["Start_Work"].ToString()), DateTime.Parse(Reader["End_Work"].ToString()), Convert.ToInt32(Reader["Count"])), typeof(T)));
                }
            }
            return list;
        }
    }
    class Insert<T> : DataBase
    {
        Type Type = typeof(T);
        string query { get; set; }
        private  T data { get; set; }
        public Insert(T data) 
        {
           
            this.data = data;
            Table_Insert();
        }
        private void Table_Insert() 
        {
            query += @$"insert into {Type.Name} "; 

            if (Type.Name == "customers_table")
            {
                customers_table obj = (customers_table)Convert.ChangeType(data, typeof(customers_table));
                query += Table_RowName(Type.Name);
                query += $@" ({obj.ID},'{obj.CardWork_ID}','{obj.Date_of_Birth.Year}-{obj.Date_of_Birth.Month}-{obj.Date_of_Birth.Day}')";
            }
            if (Type.Name == "wage_from_table")
            {
                wage_from_table obj = (wage_from_table)Convert.ChangeType(data, typeof(wage_from_table));
                query += Table_RowName(Type.Name);
                query += $@" ({obj.Wage_ID},'{obj.Name}')";
            }
            if (Type.Name == "children_table")
            {
                children_table obj = (children_table)Convert.ChangeType(data, typeof(children_table));
                query += Table_RowName(Type.Name);
                query += $@" ({obj.Customer_ID},'{obj.Name}','{obj.Date_of_Birth.Year}-{obj.Date_of_Birth.Month}-{obj.Date_of_Birth.Day}')";
            }
            if (Type.Name == "holiday_table")
            {
                holiday_table obj = (holiday_table)Convert.ChangeType(data,typeof(holiday_table));
                query += Table_RowName(Type.Name);
                query += $@" ({obj.Customer_ID},'{obj.Start_Holiday.Year}-{obj.Start_Holiday.Month}-{obj.Start_Holiday.Day}','{obj.End_Holiday.Year}-{obj.End_Holiday.Month}-{obj.End_Holiday.Day}')";
            }
            if (Type.Name == "married_table")
            {
                married_table obj = (married_table)Convert.ChangeType(data, typeof(married_table));
                query += Table_RowName(Type.Name);
                query += $@" ({obj.Customer_ID},'{obj.Name}','{obj.Start_Maried_Date.Year}-{obj.Start_Maried_Date.Month}-{obj.Start_Maried_Date.Day}')";
            }
            if (Type.Name == "schedules_table")
            {
                schedules_table obj = (schedules_table)Convert.ChangeType(data, typeof(schedules_table));
                query += Table_RowName(Type.Name);
                query += $@" ({obj.ID},{obj.Customer_ID},'{obj.StartDate.Year}-{obj.StartDate.Month}-{obj.StartDate.Day}','{obj.EndDate.Year}-{obj.EndDate.Month}-{obj.EndDate.Day}')";
            }
            if (Type.Name == "sick_table")
            {
                sick_table obj = (sick_table)Convert.ChangeType(data, typeof(sick_table));
                query += Table_RowName(Type.Name);
                query += $@" ({obj.Customer_ID},'{obj.Start_Sick.Year}-{obj.Start_Sick.Month}-{obj.Start_Sick.Day}','{obj.End_Sick.Year}-{obj.End_Sick.Month}-{obj.End_Sick.Day}')";
            }
            if (Type.Name == "working_time_table")
            {
                working_time_table obj = (working_time_table)Convert.ChangeType(data, typeof(working_time_table));
                query += Table_RowName(Type.Name);
                query += $@" ({obj.CardWork_ID},'{obj.Start_Work.Year}-{obj.Start_Work.Month}-{obj.Start_Work.Day}','{obj.End_Work.Year}-{obj.End_Work.Month}-{obj.End_Work.Day}',{obj.ID})";
            }
        }
    }
    class Delete<T> : DataBase 
    {
        Type Type = typeof(T);
        public Delete() 
        {

        }
    }
    class Update<T> : DataBase
    {
        //UPDATE Customers SET ContactName = 'Alfred Schmidt', City = 'Frankfurt' WHERE CustomerID = 1;
        Type Type = typeof(T);
        public Update() 
        {
            
        }
        public void Update_Record(int ID, string Text, string colum) 
        {
            string query = "";
            query = $@"UPDATE {Type.Name} SET {colum} = '{Text}' WHERE ID = {ID}";
            Command = new MySqlCommand(query, Connection);
            Command.ExecuteReader();
        }
    }
}
