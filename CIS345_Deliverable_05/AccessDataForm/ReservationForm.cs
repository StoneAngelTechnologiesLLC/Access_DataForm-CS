using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//John Pietrangelo CIS345 Tues/Thurs 9am 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccessDataForm
{
    public partial class ReservationForm : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=..\..\..\ExploringTravelAgent.accdb");
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exploringTravelAgentDataSet.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.exploringTravelAgentDataSet.Reservation);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
