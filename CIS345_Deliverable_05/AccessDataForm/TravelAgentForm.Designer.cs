namespace AccessDataForm
{
    partial class TravelAgentForm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.agentEmailTbx = new System.Windows.Forms.TextBox();
            this.agentPhoneTbx = new System.Windows.Forms.TextBox();
            this.agentLastNameTbx = new System.Windows.Forms.TextBox();
            this.agentFirstNameTbx = new System.Windows.Forms.TextBox();
            this.agentIDTbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messageLbl2 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agent Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.exitBtn.Location = new System.Drawing.Point(772, 399);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(122, 45);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // agentEmailTbx
            // 
            this.agentEmailTbx.Location = new System.Drawing.Point(75, 280);
            this.agentEmailTbx.Name = "agentEmailTbx";
            this.agentEmailTbx.Size = new System.Drawing.Size(257, 26);
            this.agentEmailTbx.TabIndex = 26;
            // 
            // agentPhoneTbx
            // 
            this.agentPhoneTbx.Location = new System.Drawing.Point(75, 228);
            this.agentPhoneTbx.Name = "agentPhoneTbx";
            this.agentPhoneTbx.Size = new System.Drawing.Size(257, 26);
            this.agentPhoneTbx.TabIndex = 25;
            // 
            // agentLastNameTbx
            // 
            this.agentLastNameTbx.Location = new System.Drawing.Point(111, 184);
            this.agentLastNameTbx.Name = "agentLastNameTbx";
            this.agentLastNameTbx.Size = new System.Drawing.Size(242, 26);
            this.agentLastNameTbx.TabIndex = 24;
            // 
            // agentFirstNameTbx
            // 
            this.agentFirstNameTbx.Location = new System.Drawing.Point(111, 132);
            this.agentFirstNameTbx.Name = "agentFirstNameTbx";
            this.agentFirstNameTbx.Size = new System.Drawing.Size(242, 26);
            this.agentFirstNameTbx.TabIndex = 23;
            // 
            // agentIDTbx
            // 
            this.agentIDTbx.Location = new System.Drawing.Point(66, 83);
            this.agentIDTbx.Name = "agentIDTbx";
            this.agentIDTbx.Size = new System.Drawing.Size(242, 26);
            this.agentIDTbx.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(13, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(13, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Phone: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(13, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID:";
            // 
            // messageLbl2
            // 
            this.messageLbl2.Location = new System.Drawing.Point(280, 357);
            this.messageLbl2.Name = "messageLbl2";
            this.messageLbl2.Size = new System.Drawing.Size(444, 29);
            this.messageLbl2.TabIndex = 33;
            this.messageLbl2.Visible = false;
            // 
            // editBtn
            // 
            this.editBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.editBtn.Location = new System.Drawing.Point(636, 399);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(111, 45);
            this.editBtn.TabIndex = 32;
            this.editBtn.Text = "&Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            this.editBtn.MouseLeave += new System.EventHandler(this.editBtn_MouseLeave);
            this.editBtn.MouseHover += new System.EventHandler(this.editBtn_MouseHover);
            // 
            // searchBtn
            // 
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.searchBtn.Location = new System.Drawing.Point(500, 399);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(111, 45);
            this.searchBtn.TabIndex = 31;
            this.searchBtn.Text = "&Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            this.searchBtn.MouseLeave += new System.EventHandler(this.searchBtn_MouseLeave);
            this.searchBtn.MouseHover += new System.EventHandler(this.searchBtn_MouseHover);
            // 
            // deleteBtn
            // 
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteBtn.Location = new System.Drawing.Point(357, 399);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(111, 45);
            this.deleteBtn.TabIndex = 30;
            this.deleteBtn.Text = "&Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            this.deleteBtn.MouseLeave += new System.EventHandler(this.deleteBtn_MouseLeave);
            this.deleteBtn.MouseHover += new System.EventHandler(this.deleteBtn_MouseHover);
            // 
            // insertBtn
            // 
            this.insertBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.insertBtn.Location = new System.Drawing.Point(206, 399);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(111, 45);
            this.insertBtn.TabIndex = 29;
            this.insertBtn.Text = "&Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // viewButton
            // 
            this.viewButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.viewButton.Location = new System.Drawing.Point(26, 399);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(142, 45);
            this.viewButton.TabIndex = 27;
            this.viewButton.Text = "&View Records";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(359, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(535, 262);
            this.dataGridView1.TabIndex = 34;
            // 
            // TravelAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.messageLbl2);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.agentEmailTbx);
            this.Controls.Add(this.agentPhoneTbx);
            this.Controls.Add(this.agentLastNameTbx);
            this.Controls.Add(this.agentFirstNameTbx);
            this.Controls.Add(this.agentIDTbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Name = "TravelAgentForm";
            this.Text = "Agent Management";
            this.Load += new System.EventHandler(this.TravelAgentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox agentEmailTbx;
        private System.Windows.Forms.TextBox agentPhoneTbx;
        private System.Windows.Forms.TextBox agentLastNameTbx;
        private System.Windows.Forms.TextBox agentFirstNameTbx;
        private System.Windows.Forms.TextBox agentIDTbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label messageLbl2;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}