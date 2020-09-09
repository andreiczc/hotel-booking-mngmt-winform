using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Assignment14
{
    public partial class ExistingClientForm : Form
    {
        private const string ConnectionString =
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;Persist Security Info=True";

        public List<Room> Rooms;
        public List<Client> Clients;
        private RoomTypes type;
        private Client _client;
        private Room _room;

        public ExistingClientForm(List<Room> rooms, List<Client> clients)
        {
            InitializeComponent();
            Rooms = rooms;
            Clients = clients;
        }

        public Client CheckName(string name)
        {
            foreach (var client in Clients)
            {
                if (client.FullName.ToLower() == name.ToLower())
                    return client;
            }

            return null;
        }

        public Client CheckId(int id)
        {
            foreach (var client in Clients)
            {
                if (client.ClientId == id)
                    return client;
            }

            return null;
        }

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
                        if (startDate >= reservation.EndDate || endDate > reservation.StartDate)
                        {
                            ok = false;
                            break;
                        }
                    }

                    if (ok == true)
                        return room;
                }
            }
            return null;
        }

        private void AddReservation()
        {
            const string queryString =
                "insert into Reservations(RoomId, ClientID, StartDate, EndDate, RoomType, ClientFullName) values(@roomId, @clientId, @startDate, @endDate, @roomType, @clientFullName)";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                OleDbCommand insertCommand = new OleDbCommand(queryString, connection);
                insertCommand.Parameters.Add(new OleDbParameter("@roomId", _room.RoomId));
                insertCommand.Parameters.Add(new OleDbParameter("@clientId", _client.ClientId));
                insertCommand.Parameters.Add(new OleDbParameter("@startDate", dtpStartDate.Value.Date));
                insertCommand.Parameters.Add(new OleDbParameter("@endDate", dtpEndDate.Value.Date));
                insertCommand.Parameters.Add(new OleDbParameter("@roomId", type));
                insertCommand.Parameters.Add(new OleDbParameter("@clientFullName", tbFullName.Text.Trim()));
                insertCommand.ExecuteNonQuery();

                var getIdCommand = new OleDbCommand("select @@Identity", connection);
                var reservation = new Reservation(_client, _room, dtpStartDate.Value.Date, dtpEndDate.Value.Date, type);
                reservation.ReservationId = (int)getIdCommand.ExecuteScalar();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dtpEndDate.Value > dtpStartDate.Value && dtpStartDate.Value.Date >= DateTime.Now && string.IsNullOrEmpty(tbFullName.Text.Trim()) == false && string.IsNullOrEmpty(cbRoomType.Text) == false)
            {
                epSubmit.Clear();
                _room = CheckDate(dtpStartDate.Value, dtpEndDate.Value);
                if (_room == null)
                {
                    MessageBox.Show("There is no room avalaible for this period", "Reservation failed");
                }
                else
                {
                    AddReservation();
                    MessageBox.Show("Your room is " + _room.RoomId + "\nClient ID: " + _client.ClientId,
                        "Reservation succesfull");
                    this.Close();
                }
            }
            else
            {
                epSubmit.SetError(btnSubmit, "Please check that all the data is correct");
            }
        }

        private void tbClientID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                var clientId = int.Parse(tbClientID.Text.Trim());
                _client = CheckId(clientId);
                if (_client != null)
                {
                    tbFullName.Text = _client.FullName;
                    MessageBox.Show("Client ID is valid", "Check succesfull");
                }
                else
                {
                    e.Cancel = true;
                    epClientId.SetError(tbClientID, "Please enter a valid Id");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Only numbers allowed", "Error");
                tbClientID.Text = "";
            }
        }

        private void tbClientID_Validated(object sender, EventArgs e)
        {
            epClientId.Clear();
        }

        private void tbFullName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _client = CheckName(tbFullName.Text.Trim());
            if (_client != null)
            {
                tbClientID.Text = _client.ClientId.ToString();
                MessageBox.Show("Client name is valid", "Check succesfull");
            }
            else
            {
                epName.SetError(tbFullName, "Please enter a valid full name");
                e.Cancel = true;
            }
        }

        private void tbFullName_Validated(object sender, EventArgs e)
        {
            epName.Clear();
        }

        private void ExistingClientForm_Load(object sender, EventArgs e)
        {
            cbRoomType.Text = "Single";
        }
    }
}
