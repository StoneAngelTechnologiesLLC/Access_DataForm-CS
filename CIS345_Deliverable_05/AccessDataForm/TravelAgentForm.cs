//John Pietrangelo CIS345 Tues/Thurs 9am 
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccessDataForm
{
    public partial class TravelAgentForm : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=..\..\..\ExploringTravelAgent.accdb");

        public TravelAgentForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TravelAgentForm_Load(object sender, EventArgs e)
        {
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        public void disp_data()
        {
            string strSql = "Select * from Agents";
            sql_exec(strSql);
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(agentIDTbx.Text))
            {
                messageLbl2.Visible = true;
                messageLbl2.Text = "Agent ID will be assigned by the Access DBMS";
            }
            else
            {
                if (string.IsNullOrWhiteSpace(agentFirstNameTbx.Text) ||
                    string.IsNullOrWhiteSpace(agentLastNameTbx.Text) ||
                    string.IsNullOrWhiteSpace(agentPhoneTbx.Text) ||
                    string.IsNullOrWhiteSpace(agentEmailTbx.Text))
                {
                    messageLbl2.Text = "Warning:  Some fields are missing data";
                }
                else
                {
                    string strSql = "Insert INTO Agents ([First Name], [Last Name], [Phone], [Email]) VALUES (";
                    strSql += "'" + agentFirstNameTbx.Text + "', '" + agentLastNameTbx.Text;
                    strSql += "', '" + agentPhoneTbx.Text + "', '" + agentEmailTbx.Text + "');";
                    sql_exec(strSql);
                    clearTextBox();
                    MessageBox.Show("Record inserted!!");
                    messageLbl2.Visible = false;
                }
            }
        }

        private void deleteBtn_MouseHover(object sender, EventArgs e)
        {
            agentID_check();
        }

        private void deleteBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl2.Visible = false;
            messageLbl2.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string strSql = "DELETE FROM Agents WHERE [Agent ID] = ";
            strSql += agentIDTbx.Text;
            sql_exec(strSql);
            messageLbl2.Text = "";
            //MessageBox.Show("Record deleted!");
        }

        private void searchBtn_MouseHover(object sender, EventArgs e)
        {
            agentID_check();
        }

        private void searchBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl2.Visible = false;
            messageLbl2.Text = "";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Agents where [Agent ID] = ";
            strSql += agentIDTbx.Text;
            sql_exec(strSql);
            messageLbl2.Text = "";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string strSql = "UPDATE Agents SET ";
            if (!string.IsNullOrWhiteSpace(agentFirstNameTbx.Text))
                strSql += "[First Name] = '" + agentFirstNameTbx.Text + "', ";
            if (!string.IsNullOrWhiteSpace(agentLastNameTbx.Text))
                strSql += "[Last Name] = '" + agentLastNameTbx.Text + "', ";
            if (!string.IsNullOrWhiteSpace(agentPhoneTbx.Text))
                strSql += "[Phone] = '" + agentPhoneTbx.Text + "', ";
            if (!string.IsNullOrWhiteSpace(agentEmailTbx.Text))
                strSql += "[Email] = '" + agentEmailTbx.Text + "' ";
            strSql += "WHERE[Agent ID] = ";
            strSql += agentIDTbx.Text;
            sql_exec(strSql);
            clearTextBox();
            //MessageBox.Show("Record edited!!");
        }

        private void editBtn_MouseHover(object sender, EventArgs e)
        {
            messageLbl2.Visible = true;
            messageLbl2.Text = "Please enter all fields for the operation";
        }

        private void editBtn_MouseLeave(object sender, EventArgs e)
        {
            messageLbl2.Visible = false;
            messageLbl2.Text = "";
        }

        public void clearTextBox()
        {
            agentIDTbx.Text = "";
            agentFirstNameTbx.Text = "";
            agentLastNameTbx.Text = "";
            agentPhoneTbx.Text = "";
            agentEmailTbx.Text = "";
        }

        public void agentID_check()
        {
            if (string.IsNullOrWhiteSpace(agentIDTbx.Text))
            {
                messageLbl2.Visible = true;
                messageLbl2.Text = "Please enter Agent's ID for the operation";
            }
            else
                messageLbl2.Text = "";
        }

        public void sql_exec(string strSql)
        {
            //using (OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=\Users\selin2\Documents\Visual Studio 2015\Projects\AccessDataForm\ExploringTravelAgent.accdb"))
            using (OleDbConnection con1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=ExploringTravelAgent.accdb"))

            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand(strSql, con1);
                    con1.Open();
                    cmd.CommandType = CommandType.Text;
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable agent = new DataTable();
                    da.Fill(agent);
                    dataGridView1.DataSource = agent;
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
                    con1.Close();
                }
            }
        }
    }
}
