using Bérszám.Model;
using Bérszám.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bérszám.Forms
{
    public partial class FormCustomers : Form
    {
        private List<Discounts> Discount = new List<Discounts>();
        private List<customers_table> Customers = new List<customers_table>();  
        private List<TextBox> TextBoxes = new List<TextBox>();
        private List<DataGridView> dataGridViews = new List<DataGridView>();
        private int idx = 0;
        public FormCustomers()
        {
            InitializeComponent();

        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            Customers = new Select<customers_table>().Select_querry();       
            Listboxes_set("TextBox");
            Listboxes_set("DataGridView");
            customers_table custtomers = Customers[idx];
            show_Customer(custtomers);
            

            foreach (var item in Customers)
            {
                Discount.Add(new FirstMarried(item));
                Discount.Add(new FamilyDiscount(item));

            }         
        }
        private void Listboxes_set(string type_name) 
        {
            foreach (var item in  this.Controls)
            {
                if (type_name == "TextBox") 
                {
                    if (item.GetType().Name == type_name)
                    {
                        TextBox txtb = (TextBox)item;
                        TextBoxes.Add(txtb);
                    }
                }
                if (type_name == "DataGridView")
                {
                    if (item.GetType().Name == type_name)
                    {
                        DataGridView dgv = (DataGridView)item;
                        dataGridViews.Add(dgv);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idx++;
            if (Customers.Count > idx)
            {
                customers_table custtomers = Customers[idx];
                show_Customer(custtomers);
            }
            else
            {
                idx--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idx--;
            if (idx > -1 )
            {
                customers_table custtomers = Customers[idx];
                show_Customer(custtomers);
            }
            else 
            {
                idx++;
            }
        }
        private void show_Customer(customers_table obj) 
        {
            CardWork_ID_TextBox.Text= obj.CardWork_ID.ToString();
            FirstName_TextBox.Text = obj.FirstName;
            LastName_TextBox.Text = obj.LastName;
            Mother_Name_TextBox.Text = obj.Mother_Name;
            Identity_Number_TextBox.Text = obj.Identity_Number;
            Date_of_Birth_TextBox.Text = obj.Date_of_Birth.ToString("yyyy-MM-dd");
            Place_of_Birth_TextBox.Text = obj.Place_of_Birth;
            Residence_City_TextBox.Text = obj.Residence_City;
            Residence_Street_TextBox.Text = obj.Residence_Street;
            Resindece_City_Housenumber_TextBox.Text = obj.Residence_Housenumber;
            Resindece_City_Number.Text = obj.Residence_City_number.ToString();
            TAJ_TextBox.Text = obj.TAJ_Number;
            Tax_TaxtBox.Text = obj.Tax_Number.ToString();
            Holiday_Count_TextBox.Text = obj.Holiday_Count.ToString();
            Distance_TextBox.Text = obj.Distance.ToString();
            if (obj.working_time_Table != null) 
            {
                WorkTimeData_GridView.DataSource = obj.working_time_Table;
            }
            if (obj.Holiday_Table != null)
            {
                Holiday_GridView.DataSource = obj.Holiday_Table;
            }
            if (obj.Sick_Table != null)
            {
                Sick_GridView.DataSource = obj.Sick_Table;
            }
            if (obj.Children_Table != null)
            {
                Children_GridView.DataSource = obj.Children_Table;
            }
            if (obj.Maried_Table != null)
            {
                Married_GridView.DataSource = obj.Maried_Table;
            }
            if (obj.Wage_Table != null) 
            {
                Wage_Form_ID_DataGridView.DataSource = obj.Wage_Table;
            }
            if (obj.Schedules_Table != null)
            {
                Schedules_DataGridView.DataSource = obj.Schedules_Table;
            }
        }

        private void Text_Changed_Update(object sender, EventArgs e)
        {

        }

        private void Text_Change_Enter(object sender, EventArgs e)
        {

        }

        private void CardWork_ID_TextBox_Validated(object sender, EventArgs e)
        {

        }

        private void CardWork_ID_TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox tbox = (TextBox)sender;
                new Update<customers_table>().Update_Record(Customers[idx].ID, tbox.Text, tbox.AccessibleName);
            }
            Customers = new Select<customers_table>().Select_querry();
        }

        private void Schedules_TexBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Holiday_label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TAJ_Label_Click(object sender, EventArgs e)
        {

        }

        private void Schedules_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Wage_Form_ID_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
