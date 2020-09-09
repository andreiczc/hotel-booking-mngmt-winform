using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Assignment14
{
    public partial class CheckForm : Form
    {
        #region Attributes
        private const string ConnectionString =
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;Persist Security Info=True";
        private List<Reservation> Reservations;
        private List<Room> _rooms;
        #endregion

        #region Form
        public CheckForm(List<Reservation> reservations, List<Room> rooms)
        {
            InitializeComponent();
            Reservations = reservations;
            _rooms = rooms;
        }

        private void CheckForm_Load(object sender, EventArgs e)
        {
            DisplayReservations();
        }
        #endregion

        #region Event Handlers
        private void asTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Room Number | Client Name | Client Id | Start Date | End Date");

                    foreach (var reservation in Reservations)
                    {
                        sw.WriteLine($"{reservation.RoomId} | {reservation.ClientFullName} | {reservation.ClientId}" +
                                     $" | {reservation.StartDate.ToShortDateString()} | {reservation.EndDate.ToShortDateString()}");
                    }

                    MessageBox.Show("Text write succesfull", "Operation succesfull");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to delete this reservation ?", "Delete confirmation",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Reservation reservation = lvCheck.SelectedItems[0].Tag as Reservation;
                string querySring = "delete from Reservations where ReservationId=" + reservation.ReservationId;
                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    connection.Open();
                    var command = new OleDbCommand(querySring, connection);
                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Delete succesfull", "Operation completed");

                    Reservations.Remove(reservation);
                    DisplayReservations();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var form = new UpdateForm(lvCheck.SelectedItems[0].Tag as Reservation, _rooms);
            form.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayReservations();
        }
        #endregion

        #region Methods
        private void DisplayReservations()
        {
            lvCheck.Items.Clear();
            foreach (var reservation in Reservations)
            {
                ListViewItem lvItem = new ListViewItem(reservation.RoomId.ToString());
                lvItem.SubItems.Add(reservation.ClientFullName);
                lvItem.SubItems.Add(reservation.ClientId.ToString());
                lvItem.SubItems.Add(reservation.StartDate.Date.ToString());
                lvItem.SubItems.Add(reservation.EndDate.Date.ToString());
                lvItem.Tag = reservation;
                lvCheck.Items.Add(lvItem);
            }
        }
        #endregion
    }
}
