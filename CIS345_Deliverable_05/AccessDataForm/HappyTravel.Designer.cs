namespace AccessDataForm
{
    partial class HappyTravelForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.magtCmb = new System.Windows.Forms.ComboBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(138, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Happy Travel ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(198, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select a Function:";
            // 
            // magtCmb
            // 
            this.magtCmb.FormattingEnabled = true;
            this.magtCmb.Items.AddRange(new object[] {
            "Customer Management",
            "Agent Management",
            "Tour Management",
            "Reservation management",
            "Display All Reservations"});
            this.magtCmb.Location = new System.Drawing.Point(163, 176);
            this.magtCmb.Name = "magtCmb";
            this.magtCmb.Size = new System.Drawing.Size(237, 28);
            this.magtCmb.TabIndex = 10;
            // 
            // nextBtn
            // 
            this.nextBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nextBtn.Location = new System.Drawing.Point(146, 274);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(111, 45);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.Text = "&Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.exitBtn.Location = new System.Drawing.Point(297, 274);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(118, 45);
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // HappyTravelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AccessDataForm.Properties.Resources.penguins_1550077;
            this.ClientSize = new System.Drawing.Size(581, 365);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.magtCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "HappyTravelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTravel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox magtCmb;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}