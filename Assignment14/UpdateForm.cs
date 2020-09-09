using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment14
{
    public partial class UpdateForm : Form
    {
        #region Attributes
        private Reservation _reservation;
        private List<Room> _rooms;
        private RoomTypes _type;
        private const string ConnectionString =
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;Persist Security Info=True";
        #endregion

        #region Form
        public UpdateForm(Reservation reservation, List<Room> rooms)
        {
            InitializeComponent();
            _reservation = reservation;
            _rooms = rooms;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            cbRoomType.Text = RoomTypeChecker();
            dtpStartDate.Value = _reservation.StartDate;
            dtpEndDate.Value = _reservation.EndDate;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dtpEndDate.Value > dtpStartDate.Value && dtpStartDate.Value.AddMinutes(5) >= DateTime.Now)
            {
                epSubmit.Clear();
                var room = CheckDate(dtpStartDate.Value.Date, dtpEndDate.Value.Date);
                if (room == null)
                {
                    MessageBox.Show("There is no room avalaible for this period", "Reservation failed");
                }
                else
                {
                    if (room.RoomId != _reservation.RoomId)
                    {
                        //removing reservation from original room
                        foreach (var Room in _rooms)
                        {
                            if (_reservation.RoomId == Room.RoomId)
                                Room.Reservations.Remove(_reservation);
                        }

                        MessageBox.Show("Your new room is " + room.RoomId, "Operation succesfull");
                        room.Reservations.Add(_reservation);
                    }
                    else
                        MessageBox.Show("The period of your stay has been updated", "Operation succesfull");

                    _reservation.RoomId = room.RoomId;
                    _reservation.StartDate = dtpStartDate.Value.Date;
                    _reservation.EndDate = dtpEndDate.Value.Date;  
                    
                    UpdateReservation(room, _reservation);
                }

                this.Close();
            }
            else
            {
                epSubmit.SetError(btnSubmit, "Please check that all the data is correct");
            }
        }
        #endregion

        #region Methods
        private string RoomTypeChecker()
        {
            foreach (var room in _rooms)
            {
                if (_reservation.RoomId == room.RoomId)
                    return room.RoomType.ToString();
            }

            return null;
        }

        private Room CheckDate(DateTime startDate, DateTime endDate)
        {
            if (cbRoomType.Text == "Single")
                _type = RoomTypes.Single;
            else if (cbRoomType.Text == "Couple")
                _type = RoomTypes.Couple;
            else if (cbRoomType.Text == "Family")
                _type = RoomTypes.Family;
            else
                _type = RoomTypes.Penthouse;
            bool ok = true;
            foreach (var room in _rooms)
            {
                if (room.RoomType == _type)
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

        private void UpdateReservation(Room room, Reservation reservation)
        {
            string queryString =
                "update Reservations set RoomId = @roomId, StartDate = @startDate, EndDate = @endDate, RoomType = @roomType where ReservationId = " +
                _reservation.ReservationId;
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                var command = new OleDbCommand(queryString, connection);

                command.Parameters.Add(new OleDbParameter("@roomId", room.RoomId));
                command.Parameters.Add(new OleDbParameter("@startDate", reservation.StartDate.Date));
                command.Parameters.Add(new OleDbParameter("@endDate", reservation.EndDate));
                command.Parameters.Add(new OleDbParameter("@roomType", room.RoomType));

                command.ExecuteNonQuery();
            }
        }
        #endregion    
    }
}
