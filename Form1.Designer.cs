namespace ch3_caseproblem
{
    partial class GreenvilleRevenueGUI
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
            this.lastYear = new System.Windows.Forms.Label();
            this.thisYear = new System.Windows.Forms.TextBox();
            this.lastYearTxt = new System.Windows.Forms.Label();
            this.thisYearTxt = new System.Windows.Forms.TextBox();
            this.finalButton = new System.Windows.Forms.Button();
            this.final = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastYear
            // 
            this.lastYear.AutoSize = true;
            this.lastYear.Location = new System.Drawing.Point(40, 58);
            this.lastYear.Name = "lastYear";
            this.lastYear.Size = new System.Drawing.Size(106, 17);
            this.lastYear.TabIndex = 0;
            this.lastYear.Text = "# of contestants last year";
            // 
            // thisYear
            // 
            this.thisYear.Location = new System.Drawing.Point(152, 58);
            this.thisYear.Name = "thisYear";
            this.thisYear.Size = new System.Drawing.Size(100, 22);
            this.thisYear.TabIndex = 1;
            this.thisYearLabel.Text = "# of contestants this year";
            // 
            // lastYearTxt
            // 
            this.lastYearTxt.AutoSize = true;
            this.lastYearTxt.Location = new System.Drawing.Point(12, 94);
            this.lastYearTxt.Name = "lastYearTxt";
            this.lastYearTxt.Size = new System.Drawing.Size(136, 17);
            this.lastYearTxt.TabIndex = 2;
            this.lastYearTxt.Text = "Enter another number";
            // 
            // thisYearTxt
            // 
            this.thisYearTxt.Location = new System.Drawing.Point(155, 94);
            this.thisYearTxt.Name = "thisYearTxt";
            this.thisYearTxt.Size = new System.Drawing.Size(100, 22);
            this.thisYearTxt.TabIndex = 3;
            // 
            // finalButton
            // 
            this.finalButton.Location = new System.Drawing.Point(43, 151);
            this.finalButton.Name = "finalButton";
            this.finalButton.Size = new System.Drawing.Size(106, 23);
            this.finalButton.TabIndex = 4;
            this.finalButton.Text = "Calculate";
            this.finalButton.UseVisualStyleBackColor = true;
            this.finalButton.Click += new System.EventHandler(this.finalButton_Click);
            // 
            // final
            // 
            this.final.AutoSize = true;
            this.final.Location = new System.Drawing.Point(166, 156);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(0, 17);
            this.final.TabIndex = 5;
            this.greaterLabel.Text = "final amt";
            // 
            // GreenvilleRevenueGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.final);
            this.Controls.Add(this.finalButton);
            this.Controls.Add(this.thisYearTxt);
            this.Controls.Add(this.lastYearTxt);
            this.Controls.Add(this.thisYear);
            this.Controls.Add(this.lastYear);
            this.Name = "GreenVille RevenueGUI";
            this.Text = "Calculate your revenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastYear;
        private System.Windows.Forms.TextBox thisYear;
        private System.Windows.Forms.Label lastYearTxt;
        private System.Windows.Forms.TextBox thisYearTxt;
        private System.Windows.Forms.Button finalButton;
        private System.Windows.Forms.Label final;
    }
}
