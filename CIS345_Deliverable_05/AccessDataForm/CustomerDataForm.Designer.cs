namespace AccessDataForm
{
    partial class CustomerDataForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exploringTravelAgentMidTermSolutionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exploringTravelAgentMidTermSolutionDataSet = new AccessDataForm.ExploringTravelAgentDataSet();
            this.customerTableAdapter = new AccessDataForm.ExploringTravelAgentDataSetTableAdapters.CustomerTableAdapter();
            this.viewButton = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.custIDTbx = new System.Windows.Forms.TextBox();
            this.fNameTbx = new System.Windows.Forms.TextBox();
            this.lNameTbx = new System.Windows.Forms.TextBox();
            this.phoneTbx = new System.Windows.Forms.TextBox();
            this.emailTbx = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.messageLbl = new System.Windows.Forms.Label();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exploringTravelAgentMidTermSolutionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exploringTravelAgentMidTermSolutionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(223, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.customerBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(346, 77);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(541, 321);
            this.dataGridView.TabIndex = 1;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.exploringTravelAgentMidTermSolutionDataSetBindingSource;
            // 
            // exploringTravelAgentMidTermSolutionDataSetBindingSource
            // 
            this.exploringTravelAgentMidTermSolutionDataSetBindingSource.DataSource = this.exploringTravelAgentMidTermSolutionDataSet;
            this.exploringTravelAgentMidTermSolutionDataSetBindingSource.Position = 0;
            // 
            // exploringTravelAgentMidTermSolutionDataSet
            // 
            this.exploringTravelAgentMidTermSolutionDataSet.DataSetName = "ExploringTravelAgentMidTermSolutionDataSet";
            this.exploringTravelAgentMidTermSolutionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // viewButton
            // 
            this.viewButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.viewButton.Location = new System.Drawing.Point(4, 451);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(142, 45);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "&View Records";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.exitBtn.Location = new System.Drawing.Point(760, 451);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(118, 45);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.insertBtn.Location = new System.Drawing.Point(184, 451);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(111, 45);
            this.insertBtn.TabIndex = 4;
            this.insertBtn.Text = "&Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteBtn.Location = new System.Drawing.Point(335, 451);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(111, 45);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "&Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            this.deleteBtn.MouseLeave += new System.EventHandler(this.deleteBtn_MouseLeave);
            this.deleteBtn.MouseHover += new System.EventHandler(this.deleteBtn_MouseHover);
            // 
            // searchBtn
            // 
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.searchBtn.Location = new System.Drawing.Point(478, 451);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(111, 45);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "&Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            this.searchBtn.MouseLeave += new System.EventHandler(this.searchBtn_MouseLeave);
            this.searchBtn.MouseHover += new System.EventHandler(this.searchBtn_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(0, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(0, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(0, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(0, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(0, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email:";
            // 
            // custIDTbx
            // 
            this.custIDTbx.Location = new System.Drawing.Point(53, 96);
            this.custIDTbx.Name = "custIDTbx";
            this.custIDTbx.Size = new System.Drawing.Size(242, 26);
            this.custIDTbx.TabIndex = 12;
            // 
            // fNameTbx
            // 
            this.fNameTbx.Location = new System.Drawing.Point(98, 145);
            this.fNameTbx.Name = "fNameTbx";
            this.fNameTbx.Size = new System.Drawing.Size(242, 26);
            this.fNameTbx.TabIndex = 13;
            // 
            // lNameTbx
            // 
            this.lNameTbx.Location = new System.Drawing.Point(98, 197);
            this.lNameTbx.Name = "lNameTbx";
            this.lNameTbx.Size = new System.Drawing.Size(242, 26);
            this.lNameTbx.TabIndex = 14;
            // 
            // phoneTbx
            // 
            this.phoneTbx.Location = new System.Drawing.Point(62, 241);
            this.phoneTbx.Name = "phoneTbx";
            this.phoneTbx.Size = new System.Drawing.Size(257, 26);
            this.phoneTbx.TabIndex = 15;
            // 
            // emailTbx
            // 
            this.emailTbx.Location = new System.Drawing.Point(62, 293);
            this.emailTbx.Name = "emailTbx";
            this.emailTbx.Size = new System.Drawing.Size(257, 26);
            this.emailTbx.TabIndex = 16;
            // 
            // editBtn
            // 
            this.editBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.editBtn.Location = new System.Drawing.Point(625, 451);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(111, 45);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "&Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            this.editBtn.MouseLeave += new System.EventHandler(this.editBtn_MouseLeave);
            this.editBtn.MouseHover += new System.EventHandler(this.editBtn_MouseHover);
            // 
            // messageLbl
            // 
            this.messageLbl.Location = new System.Drawing.Point(306, 411);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(444, 29);
            this.messageLbl.TabIndex = 18;
            this.messageLbl.Visible = false;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.exploringTravelAgentMidTermSolutionDataSet;
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "Customer";
            this.customerBindingSource2.DataSource = this.exploringTravelAgentMidTermSolutionDataSetBindingSource;
            // 
            // CustomerDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 508);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.emailTbx);
            this.Controls.Add(this.phoneTbx);
            this.Controls.Add(this.lNameTbx);
            this.Controls.Add(this.fNameTbx);
            this.Controls.Add(this.custIDTbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "CustomerDataForm";
            this.Text = "Customer Data Form";
            this.Load += new System.EventHandler(this.CustomerDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exploringTravelAgentMidTermSolutionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exploringTravelAgentMidTermSolutionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource exploringTravelAgentMidTermSolutionDataSetBindingSource;
        private ExploringTravelAgentDataSet exploringTravelAgentMidTermSolutionDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private ExploringTravelAgentDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox custIDTbx;
        private System.Windows.Forms.TextBox fNameTbx;
        private System.Windows.Forms.TextBox lNameTbx;
        private System.Windows.Forms.TextBox phoneTbx;
        private System.Windows.Forms.TextBox emailTbx;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource customerBindingSource2;
    }
}

