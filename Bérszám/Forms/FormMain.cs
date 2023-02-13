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
    public partial class FormMain : Form
    {
        private List<Form> FormList = new List<Form>();
        public FormMain()
        {
            InitializeComponent();         
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.AccessibleName == "menu2")
            {
                FormCustomers frm = new FormCustomers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

                if (FormList_opencheck(frm) > 0)
                {
                    this.FormContainer.Controls.Remove(FormList[FormList_opencheck(frm)]);
                    this.FormContainer.Controls.Add(frm);
                    FormList.Add(frm);
                    frm.Show();
                }
                else 
                {
                    //this.FormContainer.Controls.Remove(FormList[0]);
                    this.FormContainer.Controls.Add(frm);
                    FormList.Add(frm);
                    frm.Show();
                }
            }
            if (e.ClickedItem.AccessibleName == "menu3") 
            {
                FormSalaryCalculation frm = new FormSalaryCalculation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

                if (CheckForm(frm))
                {
                    this.FormContainer.Controls.Add(frm);
                    //this.FormContainer.Controls.Remove(FormList[0]);
                    FormList.Add(frm);
                    frm.Show();
                }
            }
        }
        // ez azért kell mert ha van már nyitott form az töltse vissza
        private int FormList_opencheck(Form form) 
        {
            var idx = FormList.FindIndex(v => v.GetType().Name == form.GetType().Name);
            return idx;
        }
        private bool CheckForm(Form form) 
        {
            var frm = FormList.Count(f => f.GetType().Name == form.GetType().Name);
            if (frm > 0) 
            {
                return false;
            }
            return true;
        }

        private void FormContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
