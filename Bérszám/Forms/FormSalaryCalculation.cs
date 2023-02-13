using Bérszám.Model;
using Bérszám.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bérszám.Forms
{
    public partial class FormSalaryCalculation : Form
    {
        private List<customers_table> Customers = new List<customers_table>();
        PDF pdf;
        public FormSalaryCalculation()
        {
            InitializeComponent();
        }
        private void FormSalaryCalculation_Load(object sender, EventArgs e)
        {
            Customers = new Select<customers_table>().Select_querry();
        }
        private void Button_AllCalculation_Click(object sender, EventArgs e)
        {
            foreach (var item in Customers)
            {
                item.CalSalary = new CalculationSalary(item);
            }
            pdf = new PDF();
        }
    }

}
