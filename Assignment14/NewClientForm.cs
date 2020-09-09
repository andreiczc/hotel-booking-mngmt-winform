using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Assignment14
{
    public partial class NewClientForm : Form
    {
        #region Attributes

        private const string ConnectionString =
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;Persist Security Info=True";
        public List<Room> Rooms;
        public List<Client> Clients;
        RoomTypes type;
        public Client Client { get; set; }
        public Reservation Reservation { get; set; }
        #endregion

        #region Form
        public NewClientForm(List<Room> rooms, List<Client> clients)
        {
            InitializeComponent();
            Rooms = rooms;
            Clients = clients;
        }

        private void NewClientForm_Load(object sender, EventArgs e)
        {
            cbRoomType.Text = "Single";
        }
        #endregion

        #region Methods
        private Room CheckDate(DateTime startDate, DateTime endDate)
        {
            if (cbRoomType.Text == "Single")
                type = RoomTypes.Single;
            else if (cbRoomType.Text == "Couple")
                type = RoomTypes.Couple;
            else if (cbRoomType.Text == "Family")
                type = RoomTypes.Family;
            else
                type = RoomTypes.Penthouse;
            bool ok = true;
            foreach (var room in Rooms)
            {
                if (room.RoomType == type)
                {
                    ok = true;
                    foreach (var reservation in room.Reservations)
                    {
                        if (endDate <= reservation.StartDate || startDate >= reservation.EndDate)
                            continue;

                        ok = false;
                        break;
                    }

                    if (ok == true)
                        return room;
                }
            }
            return null;
        }

        #endregion

        #region Handlers

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dtpStartDate.Value.AddDays(1) < DateTime.Now)
            {
                e.Cancel = true;
                epStartDate.SetError(dtpStartDate, "Please enter a valid start date");
            }
        }

        private void dtpEndDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpEndDate.Value <= dtpStartDate.Value)
            {
                e.Cancel = true;
                epEndDate.SetError(dtpEndDate, "Please enter a end date bigger than the start date");
            }
        }

        private void dtpStartDate_Validated(object sender, EventArgs e)
        {
            epStartDate.Clear();
        }

        private void dtpEndDate_Validated(object sender, EventArgs e)
        {
            epEndDate.Clear();
        }

        private void tbFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFullName.Text.Trim()))
            {
                e.Cancel = true;
                epName.SetError(tbFullName, "Please enter the full name of the client");
            }
        }

        private void tbFullName_Validated(object sender, EventArgs e)
        {
            epName.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpEndDate.Value > dtpStartDate.Value && dtpStartDate.Value.AddMinutes(5) >= DateTime.Now && string.IsNullOrEmpty(tbFullName.Text.Trim()) == false && string.IsNullOrEmpty(cbRoomType.Text) == false)
            {
                epSubmit.Clear();
                var room = CheckDate(dtpStartDate.Value.Date, dtpEndDate.Value.Date);
                if (room == null)
                {
                    MessageBox.Show("There is no room avalaible for this period", "Reservation failed");
                }
                else
                {
                    AddClient();
                    AddReservation(room);
                    MessageBox.Show("Your room is " + room.RoomId + "\nClient ID: " + Client.ClientId,
                        "Reservation succesfull");
                    this.Close();
                }
            }
            else
            {
                epSubmit.SetError(btnSubmit, "Please check that all the data is correct");
            }
        }

        #endregion

        #region DatabaseOps

        public void AddClient()
        {
            const string queryString = "insert into Clients(FullName) values(@FullName)";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                OleDbCommand insertCommand = new OleDbCommand(queryString, connection);
                var FullNamePar = new OleDbParameter("@FullName", tbFullName.Text);
                insertCommand.Parameters.Add(FullNamePar);
                insertCommand.ExecuteNonQuery();

                var getIdCommand = new OleDbCommand("select @@Identity", connection);
                Client = new Client((int)getIdCommand.ExecuteScalar(), tbFullName.Text);
                Clients.Add(Client);
            }
        }

        public void AddReservation(Room room)
        {
            const string queryString =
                "insert into Reservations(RoomId, ClientID, StartDate, EndDate, RoomType, ClientFullName) values(@roomId, @clientId, @startDate, @endDate, @roomType, @clientFullName)";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                OleDbCommand insertCommand = new OleDbCommand(queryString, connection);
                insertCommand.Parameters.Add(new OleDbParameter("@roomId", room.RoomId));
                insertCommand.Parameters.Add(new OleDbParameter("@clientId", Client.ClientId));
                insertCommand.Parameters.Add(new OleDbParameter("@startDate", dtpStartDate.Value.Date));
                insertCommand.Parameters.Add(new OleDbParameter("@endDate", dtpEndDate.Value.Date));
                insertCommand.Parameters.Add(new OleDbParameter("@roomId", type));
                insertCommand.Parameters.Add(new OleDbParameter("@clientFullName", tbFullName.Text.Trim()));
                insertCommand.ExecuteNonQuery();

                var getIdCommand = new OleDbCommand("select @@Identity", connection);
                Reservation = new Reservation(Client, room, dtpStartDate.Value.Date, dtpEndDate.Value.Date, type);
                Reservation.ReservationId = (int)getIdCommand.ExecuteScalar();
            }
        }

        #endregion
       
    }
}
