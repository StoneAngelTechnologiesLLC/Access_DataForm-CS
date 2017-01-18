namespace AccessDataForm
{
    partial class DisplayAllReservationsForm
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
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.exploringTravelAgentDataSet = new AccessDataForm.ExploringTravelAgentDataSet();
            this.exploringTravelAgentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.exploringTravelAgentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exploringTravelAgentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.HeaderLbl.Location = new System.Drawing.Point(200, 24);
            this.HeaderLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(335, 32);
            this.HeaderLbl.TabIndex = 2;
            this.HeaderLbl.Text = "Display All Reservations";
            this.HeaderLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exploringTravelAgentDataSet
            // 
            this.exploringTravelAgentDataSet.DataSetName = "ExploringTravelAgentDataSet";
            this.exploringTravelAgentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exploringTravelAgentDataSetBindingSource
            // 
            this.exploringTravelAgentDataSetBindingSource.DataSource = this.exploringTravelAgentDataSet;
            this.exploringTravelAgentDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.exploringTravelAgentDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(96, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 196);
            this.dataGridView1.TabIndex = 3;
            // 
            // DisplayAllReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 386);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HeaderLbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DisplayAllReservationsForm";
            this.Text = "DisplayAllReservationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.exploringTravelAgentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exploringTravelAgentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.BindingSource exploringTravelAgentDataSetBindingSource;
        private ExploringTravelAgentDataSet exploringTravelAgentDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}