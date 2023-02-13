namespace Bérszám.Forms
{
    partial class FormSalaryCalculation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Month_TextBox = new System.Windows.Forms.TextBox();
            this.GridView_SalaryCalculation = new System.Windows.Forms.DataGridView();
            this.Button_AllCalculation = new System.Windows.Forms.Button();
            this.Button_PersonCalculation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_StopCalculation = new System.Windows.Forms.Button();
            this.Button_All_List = new System.Windows.Forms.Button();
            this.Button_PersonReport = new System.Windows.Forms.Button();
            this.PersonListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_SalaryCalculation)).BeginInit();
            this.SuspendLayout();
            // 
            // Month_TextBox
            // 
            this.Month_TextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Month_TextBox.Location = new System.Drawing.Point(210, 23);
            this.Month_TextBox.Name = "Month_TextBox";
            this.Month_TextBox.Size = new System.Drawing.Size(64, 34);
            this.Month_TextBox.TabIndex = 0;
            // 
            // GridView_SalaryCalculation
            // 
            this.GridView_SalaryCalculation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_SalaryCalculation.Location = new System.Drawing.Point(12, 139);
            this.GridView_SalaryCalculation.Name = "GridView_SalaryCalculation";
            this.GridView_SalaryCalculation.RowTemplate.Height = 25;
            this.GridView_SalaryCalculation.Size = new System.Drawing.Size(982, 451);
            this.GridView_SalaryCalculation.TabIndex = 1;
            // 
            // Button_AllCalculation
            // 
            this.Button_AllCalculation.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_AllCalculation.Location = new System.Drawing.Point(608, 16);
            this.Button_AllCalculation.Name = "Button_AllCalculation";
            this.Button_AllCalculation.Size = new System.Drawing.Size(145, 43);
            this.Button_AllCalculation.TabIndex = 4;
            this.Button_AllCalculation.Text = "All Calculation";
            this.Button_AllCalculation.UseVisualStyleBackColor = true;
            this.Button_AllCalculation.Click += new System.EventHandler(this.Button_AllCalculation_Click);
            // 
            // Button_PersonCalculation
            // 
            this.Button_PersonCalculation.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_PersonCalculation.Location = new System.Drawing.Point(776, 16);
            this.Button_PersonCalculation.Name = "Button_PersonCalculation";
            this.Button_PersonCalculation.Size = new System.Drawing.Size(192, 43);
            this.Button_PersonCalculation.TabIndex = 5;
            this.Button_PersonCalculation.Text = "Person Calculation";
            this.Button_PersonCalculation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Számfejtési Hónap:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(310, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Személy:";
            // 
            // Button_StopCalculation
            // 
            this.Button_StopCalculation.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_StopCalculation.Location = new System.Drawing.Point(12, 79);
            this.Button_StopCalculation.Name = "Button_StopCalculation";
            this.Button_StopCalculation.Size = new System.Drawing.Size(192, 43);
            this.Button_StopCalculation.TabIndex = 9;
            this.Button_StopCalculation.Text = "Stop_Calculation";
            this.Button_StopCalculation.UseVisualStyleBackColor = true;
            // 
            // Button_All_List
            // 
            this.Button_All_List.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_All_List.Location = new System.Drawing.Point(242, 79);
            this.Button_All_List.Name = "Button_All_List";
            this.Button_All_List.Size = new System.Drawing.Size(192, 43);
            this.Button_All_List.TabIndex = 10;
            this.Button_All_List.Text = "Összesitett Lista";
            this.Button_All_List.UseVisualStyleBackColor = true;
            // 
            // Button_PersonReport
            // 
            this.Button_PersonReport.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_PersonReport.Location = new System.Drawing.Point(469, 79);
            this.Button_PersonReport.Name = "Button_PersonReport";
            this.Button_PersonReport.Size = new System.Drawing.Size(206, 43);
            this.Button_PersonReport.TabIndex = 11;
            this.Button_PersonReport.Text = "Személyenkénti Lista";
            this.Button_PersonReport.UseVisualStyleBackColor = true;
            // 
            // PersonListBox
            // 
            this.PersonListBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PersonListBox.FormattingEnabled = true;
            this.PersonListBox.ItemHeight = 28;
            this.PersonListBox.Location = new System.Drawing.Point(415, 27);
            this.PersonListBox.Name = "PersonListBox";
            this.PersonListBox.Size = new System.Drawing.Size(159, 32);
            this.PersonListBox.TabIndex = 12;
            // 
            // FormSalaryCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 602);
            this.Controls.Add(this.PersonListBox);
            this.Controls.Add(this.Button_PersonReport);
            this.Controls.Add(this.Button_All_List);
            this.Controls.Add(this.Button_StopCalculation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_PersonCalculation);
            this.Controls.Add(this.Button_AllCalculation);
            this.Controls.Add(this.GridView_SalaryCalculation);
            this.Controls.Add(this.Month_TextBox);
            this.Name = "FormSalaryCalculation";
            this.Text = "FormSalaryCalculation";
            this.Load += new System.EventHandler(this.FormSalaryCalculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_SalaryCalculation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Month_TextBox;
        private DataGridView GridView_SalaryCalculation;
        private Button Button_AllCalculation;
        private Button Button_PersonCalculation;
        private Label label1;
        private Label label2;
        private Button Button_StopCalculation;
        private Button Button_All_List;
        private Button Button_PersonReport;
        private ListBox PersonListBox;
    }
}