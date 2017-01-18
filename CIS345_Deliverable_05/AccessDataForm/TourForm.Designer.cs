namespace AccessDataForm
{
    partial class TourForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tourIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripLengthInDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exploringTravelAgentDataSet = new AccessDataForm.ExploringTravelAgentDataSet();
            this.tourTableAdapter = new AccessDataForm.ExploringTravelAgentDataSetTableAdapters.TourTableAdapter();
            this.tourIDLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vwRcrdBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.deletBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.tourIDTxBx = new System.Windows.Forms.TextBox();
            this.tripLengthTxBx = new System.Windows.Forms.TextBox();
            this.destinationTxBx = new System.Windows.Forms.TextBox();
            this.pPPTxBx = new System.Windows.Forms.TextBox();
            this.detailTxBx = new System.Windows.Forms.TextBox();
            this.messageLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exploringTravelAgentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tour Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tourIDDataGridViewTextBoxColumn,
            this.tripLengthInDaysDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.detailDataGridViewTextBoxColumn,
            this.pricePerPersonDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tourBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(229, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(481, 194);
            this.dataGridView2.TabIndex = 2;
            // 
            // tourIDDataGridViewTextBoxColumn
            // 
            this.tourIDDataGridViewTextBoxColumn.DataPropertyName = "Tour ID";
            this.tourIDDataGridViewTextBoxColumn.HeaderText = "Tour ID";
            this.tourIDDataGridViewTextBoxColumn.Name = "tourIDDataGridViewTextBoxColumn";
            this.tourIDDataGridViewTextBoxColumn.Width = 68;
            // 
            // tripLengthInDaysDataGridViewTextBoxColumn
            // 
            this.tripLengthInDaysDataGridViewTextBoxColumn.DataPropertyName = "TripLengthInDays";
            this.tripLengthInDaysDataGridViewTextBoxColumn.HeaderText = "TripLengthInDays";
            this.tripLengthInDaysDataGridViewTextBoxColumn.Name = "tripLengthInDaysDataGridViewTextBoxColumn";
            this.tripLengthInDaysDataGridViewTextBoxColumn.Width = 116;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.Width = 85;
            // 
            // detailDataGridViewTextBoxColumn
            // 
            this.detailDataGridViewTextBoxColumn.DataPropertyName = "Detail";
            this.detailDataGridViewTextBoxColumn.HeaderText = "Detail";
            this.detailDataGridViewTextBoxColumn.Name = "detailDataGridViewTextBoxColumn";
            this.detailDataGridViewTextBoxColumn.Width = 59;
            // 
            // pricePerPersonDataGridViewTextBoxColumn
            // 
            this.pricePerPersonDataGridViewTextBoxColumn.DataPropertyName = "PricePerPerson";
            this.pricePerPersonDataGridViewTextBoxColumn.HeaderText = "PricePerPerson";
            this.pricePerPersonDataGridViewTextBoxColumn.Name = "pricePerPersonDataGridViewTextBoxColumn";
            this.pricePerPersonDataGridViewTextBoxColumn.Width = 105;
            // 
            // tourBindingSource
            // 
            this.tourBindingSource.DataMember = "Tour";
            this.tourBindingSource.DataSource = this.exploringTravelAgentDataSet;
            // 
            // exploringTravelAgentDataSet
            // 
            this.exploringTravelAgentDataSet.DataSetName = "ExploringTravelAgentDataSet";
            this.exploringTravelAgentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tourTableAdapter
            // 
            this.tourTableAdapter.ClearBeforeFill = true;
            // 
            // tourIDLbl
            // 
            this.tourIDLbl.AllowDrop = true;
            this.tourIDLbl.AutoSize = true;
            this.tourIDLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tourIDLbl.Location = new System.Drawing.Point(32, 49);
            this.tourIDLbl.Name = "tourIDLbl";
            this.tourIDLbl.Size = new System.Drawing.Size(89, 15);
            this.tourIDLbl.TabIndex = 3;
            this.tourIDLbl.Text = "Enter Tour ID: ";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "(Format Example: Txx)";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trip Length in Days:";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Destination:";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Detail:";
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price-Per-Person:";
            // 
            // vwRcrdBtn
            // 
            this.vwRcrdBtn.AutoSize = true;
            this.vwRcrdBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vwRcrdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vwRcrdBtn.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vwRcrdBtn.Location = new System.Drawing.Point(229, 249);
            this.vwRcrdBtn.Name = "vwRcrdBtn";
            this.vwRcrdBtn.Size = new System.Drawing.Size(108, 34);
            this.vwRcrdBtn.TabIndex = 9;
            this.vwRcrdBtn.Text = "&View Records";
            this.vwRcrdBtn.UseVisualStyleBackColor = false;
            this.vwRcrdBtn.Click += new System.EventHandler(this.vwRcrdBtn_Click);
            this.vwRcrdBtn.MouseLeave += new System.EventHandler(this.vwRcrdBtn_MouseLeave);
            this.vwRcrdBtn.MouseHover += new System.EventHandler(this.vwRcrdBtn_MouseHover);
            // 
            // insertBtn
            // 
            this.insertBtn.AutoSize = true;
            this.insertBtn.BackColor = System.Drawing.Color.Silver;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(343, 249);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(60, 34);
            this.insertBtn.TabIndex = 10;
            this.insertBtn.Text = "&Insert";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            this.insertBtn.MouseLeave += new System.EventHandler(this.insertBtn_MouseLeave);
            this.insertBtn.MouseHover += new System.EventHandler(this.insertBtn_MouseHover);
            // 
            // deletBtn
            // 
            this.deletBtn.AutoSize = true;
            this.deletBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deletBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletBtn.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletBtn.Location = new System.Drawing.Point(409, 249);
            this.deletBtn.Name = "deletBtn";
            this.deletBtn.Size = new System.Drawing.Size(64, 34);
            this.deletBtn.TabIndex = 11;
            this.deletBtn.Text = "&Delete";
            this.deletBtn.UseVisualStyleBackColor = false;
            this.deletBtn.Click += new System.EventHandler(this.deletBtn_Click);
            this.deletBtn.MouseLeave += new System.EventHandler(this.deletBtn_MouseLeave);
            this.deletBtn.MouseHover += new System.EventHandler(this.deletBtn_MouseHover);
            // 
            // searchBtn
            // 
            this.searchBtn.AutoSize = true;
            this.searchBtn.BackColor = System.Drawing.Color.Silver;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(479, 249);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(62, 34);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "&Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            this.searchBtn.MouseLeave += new System.EventHandler(this.searchBtn_MouseLeave);
            this.searchBtn.MouseHover += new System.EventHandler(this.searchBtn_MouseHover);
            // 
            // editBtn
            // 
            this.editBtn.AutoSize = true;
            this.editBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(547, 249);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(49, 34);
            this.editBtn.TabIndex = 13;
            this.editBtn.Text = "&Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            this.editBtn.MouseLeave += new System.EventHandler(this.editBtn_MouseLeave);
            this.editBtn.MouseHover += new System.EventHandler(this.editBtn_MouseHover);
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = true;
            this.clearBtn.BackColor = System.Drawing.Color.Silver;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(602, 249);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(54, 34);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            this.clearBtn.MouseLeave += new System.EventHandler(this.clearBtn_MouseLeave);
            this.clearBtn.MouseHover += new System.EventHandler(this.clearBtn_MouseHover);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(662, 249);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(48, 34);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            this.exitBtn.MouseHover += new System.EventHandler(this.exitBtn_MouseHover);
            // 
            // tourIDTxBx
            // 
            this.tourIDTxBx.BackColor = System.Drawing.Color.Linen;
            this.tourIDTxBx.Location = new System.Drawing.Point(123, 49);
            this.tourIDTxBx.Name = "tourIDTxBx";
            this.tourIDTxBx.Size = new System.Drawing.Size(100, 20);
            this.tourIDTxBx.TabIndex = 16;
            // 
            // tripLengthTxBx
            // 
            this.tripLengthTxBx.BackColor = System.Drawing.Color.Linen;
            this.tripLengthTxBx.Location = new System.Drawing.Point(123, 90);
            this.tripLengthTxBx.Name = "tripLengthTxBx";
            this.tripLengthTxBx.Size = new System.Drawing.Size(100, 20);
            this.tripLengthTxBx.TabIndex = 17;
            // 
            // destinationTxBx
            // 
            this.destinationTxBx.BackColor = System.Drawing.Color.Linen;
            this.destinationTxBx.Location = new System.Drawing.Point(123, 129);
            this.destinationTxBx.Name = "destinationTxBx";
            this.destinationTxBx.Size = new System.Drawing.Size(100, 20);
            this.destinationTxBx.TabIndex = 18;
            // 
            // pPPTxBx
            // 
            this.pPPTxBx.BackColor = System.Drawing.Color.Linen;
            this.pPPTxBx.Location = new System.Drawing.Point(123, 201);
            this.pPPTxBx.Name = "pPPTxBx";
            this.pPPTxBx.Size = new System.Drawing.Size(100, 20);
            this.pPPTxBx.TabIndex = 19;
            // 
            // detailTxBx
            // 
            this.detailTxBx.BackColor = System.Drawing.Color.Linen;
            this.detailTxBx.Location = new System.Drawing.Point(123, 164);
            this.detailTxBx.Name = "detailTxBx";
            this.detailTxBx.Size = new System.Drawing.Size(100, 20);
            this.detailTxBx.TabIndex = 20;
            // 
            // messageLbl
            // 
            this.messageLbl.Location = new System.Drawing.Point(35, 249);
            this.messageLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(187, 34);
            this.messageLbl.TabIndex = 21;
            this.messageLbl.Visible = false;
            // 
            // TourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(716, 284);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.detailTxBx);
            this.Controls.Add(this.pPPTxBx);
            this.Controls.Add(this.destinationTxBx);
            this.Controls.Add(this.tripLengthTxBx);
            this.Controls.Add(this.tourIDTxBx);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deletBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.vwRcrdBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tourIDLbl);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TourForm";
            this.Text = "Tour Management";
            this.Load += new System.EventHandler(this.TourForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exploringTravelAgentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ExploringTravelAgentDataSet exploringTravelAgentDataSet;
        private System.Windows.Forms.BindingSource tourBindingSource;
        private ExploringTravelAgentDataSetTableAdapters.TourTableAdapter tourTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripLengthInDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label tourIDLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button vwRcrdBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button deletBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox tourIDTxBx;
        private System.Windows.Forms.TextBox tripLengthTxBx;
        private System.Windows.Forms.TextBox destinationTxBx;
        private System.Windows.Forms.TextBox pPPTxBx;
        private System.Windows.Forms.TextBox detailTxBx;
        private System.Windows.Forms.Label messageLbl;
    }
}