namespace Bérszám.Forms
{
    partial class FormMain
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.beállitásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolgozókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bérszámfejtésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormContainer = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beállitásokToolStripMenuItem,
            this.dolgozókToolStripMenuItem,
            this.bérszámfejtésToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(951, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip2";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // beállitásokToolStripMenuItem
            // 
            this.beállitásokToolStripMenuItem.AccessibleName = "menu1";
            this.beállitásokToolStripMenuItem.Name = "beállitásokToolStripMenuItem";
            this.beállitásokToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.beállitásokToolStripMenuItem.Text = "Beállitások";
            // 
            // dolgozókToolStripMenuItem
            // 
            this.dolgozókToolStripMenuItem.AccessibleName = "menu2";
            this.dolgozókToolStripMenuItem.Name = "dolgozókToolStripMenuItem";
            this.dolgozókToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.dolgozókToolStripMenuItem.Text = "Dolgozók";
            // 
            // bérszámfejtésToolStripMenuItem
            // 
            this.bérszámfejtésToolStripMenuItem.AccessibleName = "menu3";
            this.bérszámfejtésToolStripMenuItem.Name = "bérszámfejtésToolStripMenuItem";
            this.bérszámfejtésToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.bérszámfejtésToolStripMenuItem.Text = "Bérszámfejtés";
            // 
            // FormContainer
            // 
            this.FormContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormContainer.Location = new System.Drawing.Point(0, 27);
            this.FormContainer.Name = "FormContainer";
            this.FormContainer.Size = new System.Drawing.Size(951, 543);
            this.FormContainer.TabIndex = 5;
            this.FormContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.FormContainer_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 571);
            this.Controls.Add(this.FormContainer);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menu;
        private ToolStripMenuItem beállitásokToolStripMenuItem;
        private ToolStripMenuItem dolgozókToolStripMenuItem;
        private ToolStripMenuItem bérszámfejtésToolStripMenuItem;
        private Panel FormContainer;
    }
}