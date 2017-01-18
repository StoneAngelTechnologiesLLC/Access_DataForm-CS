//John Pietrangelo CIS345 Tues/Thurs 9am 
using System;
using System.Windows.Forms;

namespace AccessDataForm
{
    public partial class HappyTravelForm : Form
    {
        public HappyTravelForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            switch (magtCmb.SelectedIndex)
            {
                case 0:
                    CustomerDataForm myCustomerForm = new CustomerDataForm();
                    myCustomerForm.Show();
                    break;
                case 1:
                    TravelAgentForm myAgentForm = new TravelAgentForm();
                    myAgentForm.Show();
                    break;
                case 2:
                    TourForm myTourForm = new TourForm();
                    myTourForm.Show();
                    break;
                case 3:
                    ReservationForm myReservationForm = new ReservationForm();
                    myReservationForm.Show();
                    break;
                case 4:
                    DisplayAllReservationsForm myDisplayAllReservationForm = new DisplayAllReservationsForm();
                    myDisplayAllReservationForm.Show();
                    break;
                default:
                    MessageBox.Show("Please make a user selection before continue",
                        "Warning!!", MessageBoxButtons.OK);
                    break;
            }

        }
    }
}
