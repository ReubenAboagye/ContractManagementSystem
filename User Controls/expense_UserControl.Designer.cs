namespace ContractManagementSystem.User_Controls
{
    partial class expense_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(expense_UserControl));
            this.Expense_tabPage = new Bunifu.UI.WinForms.BunifuPages();
            this.ExSummary_PAge = new System.Windows.Forms.TabPage();
            this.AddExpense = new System.Windows.Forms.TabPage();
            this.Expense_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Expense_tabPage
            // 
            this.Expense_tabPage.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Expense_tabPage.AllowTransitions = false;
            this.Expense_tabPage.Controls.Add(this.ExSummary_PAge);
            this.Expense_tabPage.Controls.Add(this.AddExpense);
            this.Expense_tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Expense_tabPage.Location = new System.Drawing.Point(0, 0);
            this.Expense_tabPage.Multiline = true;
            this.Expense_tabPage.Name = "Expense_tabPage";
            this.Expense_tabPage.Page = this.ExSummary_PAge;
            this.Expense_tabPage.PageIndex = 0;
            this.Expense_tabPage.PageName = "ExSummary_PAge";
            this.Expense_tabPage.PageTitle = "Expense";
            this.Expense_tabPage.SelectedIndex = 0;
            this.Expense_tabPage.Size = new System.Drawing.Size(1350, 744);
            this.Expense_tabPage.TabIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Expense_tabPage.Transition = animation1;
            this.Expense_tabPage.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // ExSummary_PAge
            // 
            this.ExSummary_PAge.Location = new System.Drawing.Point(4, 4);
            this.ExSummary_PAge.Name = "ExSummary_PAge";
            this.ExSummary_PAge.Padding = new System.Windows.Forms.Padding(3);
            this.ExSummary_PAge.Size = new System.Drawing.Size(1342, 718);
            this.ExSummary_PAge.TabIndex = 0;
            this.ExSummary_PAge.Text = "Expense";
            this.ExSummary_PAge.UseVisualStyleBackColor = true;
            // 
            // AddExpense
            // 
            this.AddExpense.Location = new System.Drawing.Point(4, 4);
            this.AddExpense.Name = "AddExpense";
            this.AddExpense.Padding = new System.Windows.Forms.Padding(3);
            this.AddExpense.Size = new System.Drawing.Size(1342, 718);
            this.AddExpense.TabIndex = 1;
            this.AddExpense.Text = "Add Expense";
            this.AddExpense.UseVisualStyleBackColor = true;
            // 
            // expense_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Expense_tabPage);
            this.Name = "expense_UserControl";
            this.Size = new System.Drawing.Size(1350, 744);
            this.Expense_tabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPages Expense_tabPage;
        private System.Windows.Forms.TabPage ExSummary_PAge;
        private System.Windows.Forms.TabPage AddExpense;
    }
}
