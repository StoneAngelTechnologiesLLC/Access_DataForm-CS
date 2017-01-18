//John Pietrangelo CIS345 Tues/Thurs 9am 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccessDataForm
{
    public partial class TourForm : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=..\..\..\ExploringTravelAgent.accdb");
//---------------------------------------------------------------------------------------------------------------------------------------------
        public TourForm()
        {
            InitializeComponent();
        }
//---------------------------------------------------------------------------------------------------------------------------------------------
        private void TourForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exploringTravelAgentDataSet.Tour' table. You can move, or remove it, as needed.
            //this.tourTableAdapter.Fill(this.exploringTravelAgentDataSet.Tour);

        }
//---------------------------------------------------------------------------------------------------------------------------------------------
        private void vwRcrdBtn_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void vwRcrdBtn_MouseHover(object sender, EventArgs e)
        {
            TourID_Check();
        }
        private void vwRcrdBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl.Visible = false;
            messageLbl.Text = "";
        }
//---------------------------------------------------------------------------------------------------------------------------------------------
        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tourIDTxBx.Text))
                messageLbl.Text = "Tour ID will be assigned by the Access DBMS";
                string strSql = "Insert INTO Tour ([Days Lenght in Days], [Destination], Price Per Person, Detail) VALUES (";
                strSql += "'" + tripLengthTxBx.Text + "', '" + destinationTxBx.Text;
                strSql += "', '" + pPPTxBx.Text + "', '" + detailTxBx.Text + "');";
                SQL_Exec(strSql);
                ClearTextBox();
                MessageBox.Show("Record inserted!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insertBtn_MouseHover(object sender, EventArgs e)
        {
            TourID_Check();
        }

        private void insertBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl.Visible = false;
            messageLbl.Text = "";
        }
//---------------------------------------------------------------------------------------------------------------------------------------------
        private void deletBtn_Click(object sender, EventArgs e)
        {
            string strSql = "DELETE FROM Tour WHERE [Tour ID] = ";
            strSql += tourIDTxBx.Text;
            SQL_Exec(strSql);
            messageLbl.Text = "";
            MessageBox.Show("Record deleted!");
        }
        private void deletBtn_MouseHover(object sender, EventArgs e)
        {
            TourID_Check();
        }

        private void deletBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl.Visible = false;
            messageLbl.Text = "";
        }
//---------------------------------------------------------------------------------------------------------------------------------------------
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Tour where [Tour ID] = ";
            strSql += tourIDTxBx.Text;
            SQL_Exec(strSql);
            messageLbl.Text = "";
        }
        private void searchBtn_MouseHover(object sender, EventArgs e)
        {
            TourID_Check();
        }

        private void searchBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl.Visible = false;
            messageLbl.Text = "";
        }
//---------------------------------------------------------------------------------------------------------------------------------------------
        private void editBtn_Click(object sender, EventArgs e)
        {
            string strSql = "UPDATE Tour SET ";
            if (!string.IsNullOrWhiteSpace(tripLengthTxBx.Text))
                strSql += "[TripLengthInDays] = '" + tripLengthTxBx.Text + "', ";
            if (!string.IsNullOrWhiteSpace(destinationTxBx.Text))
                strSql += "[Destination] = '" + destinationTxBx.Text + "', ";
            if (!string.IsNullOrWhiteSpace(detailTxBx.Text))
                strSql += "[Detail] = '" + detailTxBx.Text + "', ";
            if (!string.IsNullOrWhiteSpace(pPPTxBx.Text))
                strSql += "[PricePerPerson] = '" + pPPTxBx.Text + "' ";
            strSql += "WHERE[Tour ID] = ";
            strSql += tourIDTxBx.Text;
            MessageBox.Show(strSql);
            SQL_Exec(strSql);
            ClearTextBox();
        }
        private void editBtn_MouseHover(object sender, EventArgs e)
        {
            TourID_Check();
        }

        private void editBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl.Visible = false;
            messageLbl.Text = "";
        }
//---------------------------------------------------------------------------------------------------------------------------------------------
        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        private void clearBtn_MouseHover(object sender, EventArgs e)
        {
            TourID_Check();
        }

        private void clearBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl.Visible = false;
            messageLbl.Text = "";
        }
//---------------------------------------------------------------------------------------------------------------------------------------------
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void exitBtn_MouseHover(object sender, EventArgs e)
        {
            TourID_Check();
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl.Visible = false;
            messageLbl.Text = "";
        }
//------------------------------------------------------------------------------------------------------------------------------------
//---------------------------INTERNAL PROCESS METHODS---------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------------------------------

        public void SQL_Exec(string strSql)
        {
            using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=\Users\selin2\Documents\Visual Studio 2015\Projects\AccessDataForm\ExploringTravelAgent.accdb"))
           // using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=ExploringTravelAgent.accdb"))
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand(strSql, con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    OleDbDataAdapter dc = new OleDbDataAdapter(cmd);
                    DataTable tours = new DataTable();
                    dc.Fill(tours);
                    dataGridView2.DataSource = tours;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
//------------------------------------------------------------------------------------------------------------------------------------
        public void ClearTextBox()
        {
            tourIDTxBx.Text = "";
            tripLengthTxBx.Text = "";
            destinationTxBx.Text = "";
            detailTxBx.Text = "";
            pPPTxBx.Text = "";
        }
//------------------------------------------------------------------------------------------------------------------------------------
        public void TourID_Check()
        {
            if (string.IsNullOrWhiteSpace(tourIDTxBx.Text))
            {
                messageLbl.Visible = true;
                messageLbl.Text = "Please enter Tour ID for the operation";
            }
            else
                messageLbl.Text = "";
        }
//------------------------------------------------------------------------------------------------------------------------------------
        public void DisplayData()
        {
            string strSql = "Select * from Tour";
            SQL_Exec(strSql);
        }
    }
}
