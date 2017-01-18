namespace AccessDataForm
{
    partial class ReservationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.custIDTbx = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewButton = new System.Windows.Forms.Button();
            this.messageLbl = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.exploringTravelAgentDataSet = new AccessDataForm.ExploringTravelAgentDataSet();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter = new AccessDataForm.ExploringTravelAgentDataSetTableAdapters.ReservationTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exploringTravelAgentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ReservationInformation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the Reservation ID that will be searched: ";
            // 
            // custIDTbx
            // 
            this.custIDTbx.Location = new System.Drawing.Point(573, 93);
            this.custIDTbx.Name = "custIDTbx";
            this.custIDTbx.Size = new System.Drawing.Size(273, 26);
            this.custIDTbx.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.agentIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.tourIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.reservationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(855, 235);
            this.dataGridView1.TabIndex = 4;
            // 
            // viewButton
            // 
            this.viewButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.viewButton.Location = new System.Drawing.Point(1, 428);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(142, 45);
            this.viewButton.TabIndex = 5;
            this.viewButton.Text = "&View Records";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // messageLbl
            // 
            this.messageLbl.Location = new System.Drawing.Point(283, 388);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(444, 29);
            this.messageLbl.TabIndex = 24;
            // 
            // editBtn
            // 
            this.editBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.editBtn.Location = new System.Drawing.Point(591, 428);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(111, 45);
            this.editBtn.TabIndex = 23;
            this.editBtn.Text = "&Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.searchBtn.Location = new System.Drawing.Point(455, 428);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(111, 45);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "&Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteBtn.Location = new System.Drawing.Point(312, 428);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(111, 45);
            this.deleteBtn.TabIndex = 21;
            this.deleteBtn.Text = "&Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // insertBtn
            // 
            this.insertBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.insertBtn.Location = new System.Drawing.Point(161, 428);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(111, 45);
            this.insertBtn.TabIndex = 20;
            this.insertBtn.Text = "&Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.exitBtn.Location = new System.Drawing.Point(737, 428);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(118, 45);
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // exploringTravelAgentDataSet
            // 
            this.exploringTravelAgentDataSet.DataSetName = "ExploringTravelAgentDataSet";
            this.exploringTravelAgentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "Reservation";
            this.reservationBindingSource.DataSource = this.exploringTravelAgentDataSet;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Reservation ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Reservation ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // agentIDDataGridViewTextBoxColumn
            // 
            this.agentIDDataGridViewTextBoxColumn.DataPropertyName = "Agent ID";
            this.agentIDDataGridViewTextBoxColumn.HeaderText = "Agent ID";
            this.agentIDDataGridViewTextBoxColumn.Name = "agentIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // tourIDDataGridViewTextBoxColumn
            // 
            this.tourIDDataGridViewTextBoxColumn.DataPropertyName = "Tour ID";
            this.tourIDDataGridViewTextBoxColumn.HeaderText = "Tour ID";
            this.tourIDDataGridViewTextBoxColumn.Name = "tourIDDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ReservationDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "ReservationDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NumberOfPeople";
            this.dataGridViewTextBoxColumn3.HeaderText = "NumberOfPeople";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TravelDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "TravelDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 478);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.custIDTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReservationForm";
            this.Text = "ReservationFrom";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exploringTravelAgentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custIDTbx;
        private System.Windows.Forms.DataGridView dataGridView1;
        /*
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceQuotedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalQuoteDataGridViewTextBoxColumn;
        */
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button exitBtn;
        private ExploringTravelAgentDataSet exploringTravelAgentDataSet;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private ExploringTravelAgentDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}