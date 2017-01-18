//John Pietrangelo CIS345 Tues/Thurs 9am 
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccessDataForm
{
    public partial class CustomerDataForm : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=..\..\..\ExploringTravelAgent.accdb");
        public CustomerDataForm()
        {
            InitializeComponent();
        }

        private void CustomerDataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exploringTravelAgentMidTermSolutionDataSet.Customer' table. You can move, or remove it, as needed.
           // this.customerTableAdapter.Fill(exploringTravelAgentMidTermSolutionDataSet.Customer);

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(custIDTbx.Text))
                    messageLbl.Text = "Customer ID will be assigned by the Access DBMS";
                string strSql = "Insert INTO Customer ([First Name], [Last Name], Phone, Email) VALUES (";
                strSql += "'" + fNameTbx.Text + "', '" + lNameTbx.Text;
                strSql += "', '" + phoneTbx.Text + "', '" + emailTbx.Text + "');";
                sql_exec(strSql);
                clearTextBox();
                MessageBox.Show("Record inserted!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void disp_data()
        {
            string strSql = "Select * from Customer";
            sql_exec(strSql);
        }

        private void searchBtn_MouseHover(object sender, EventArgs e)
        {
            custID_check();
        }

        private void searchBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl.Visible = false;
            messageLbl.Text = "";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Customer where [Customer ID] = ";
            strSql += custIDTbx.Text;
            sql_exec(strSql);
            messageLbl.Text = "";
        }

        private void deleteBtn_MouseHover(object sender, EventArgs e)
        {
            custID_check();
        }

        private void deleteBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl.Visible = false;
            messageLbl.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string strSql = "DELETE FROM Customer WHERE [Customer ID] = ";
            strSql += custIDTbx.Text;
            sql_exec(strSql);
            messageLbl.Text = "";
            MessageBox.Show("Record deleted!");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string strSql = "UPDATE Customer SET ";
            if (!string.IsNullOrWhiteSpace(fNameTbx.Text))
                strSql += "[First Name] = '" + fNameTbx.Text +"', ";
            if (!string.IsNullOrWhiteSpace(lNameTbx.Text))
                strSql += "[Last Name] = '" + lNameTbx.Text + "', ";
            if (!string.IsNullOrWhiteSpace(phoneTbx.Text))
                strSql += "[Phone] = '" + phoneTbx.Text + "', ";
            if (!string.IsNullOrWhiteSpace(emailTbx.Text))
                strSql += "[Email] = '" + emailTbx.Text + "' ";
            strSql += "WHERE[Customer ID] = ";
            strSql += custIDTbx.Text;
            MessageBox.Show(strSql);
            sql_exec(strSql);
            clearTextBox();
        }

        private void editBtn_MouseHover(object sender, EventArgs e)
        {
            messageLbl.Visible = true;
            messageLbl.Text = "Please enter all fields for the operation";
        }

        private void editBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl.Visible = false;
            messageLbl.Text = "";
        }

        public void custID_check()
        {
            if (string.IsNullOrWhiteSpace(custIDTbx.Text))
            {
                messageLbl.Visible = true;
                messageLbl.Text = "Please enter Customer ID for the operation";
            }
            else
                messageLbl.Text = "";
        }

        public void sql_exec(string strSql)
        {
            //using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=\Users\selin2\Documents\Visual Studio 2015\Projects\AccessDataForm\ExploringTravelAgent.accdb"))
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=ExploringTravelAgent.accdb"))
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand(strSql, con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    OleDbDataAdapter dc = new OleDbDataAdapter(cmd);
                    DataTable customers = new DataTable();
                    dc.Fill(customers);
                    dataGridView.DataSource = customers;
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

        public void clearTextBox()
        {
            custIDTbx.Text = "";
            fNameTbx.Text = "";
            lNameTbx.Text = "";
            phoneTbx.Text = "";
            emailTbx.Text = "";
        }
    }
}
