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
    public partial class AddRoomForm : Form
    {
        private const string ConnectionString =
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;Persist Security Info=True";

        private RoomTypes type;
        private List<Room> _rooms;
        private int _roomId;

        public AddRoomForm(List<Room> rooms)
        {
            InitializeComponent();
            _rooms = rooms;
            cbRoomType.Text = "Single";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRoomId.Text.Trim()) == false)
            {
                CheckType();
                var room = new Room(_roomId, type);
                AddRoom(room);
                MessageBox.Show("New room created succesfully");
                this.Close();
            }
        }

        private void tbRoomId_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                _roomId = int.Parse(tbRoomId.Text.Trim());
            }
            catch (FormatException ex)
            {
                e.Cancel = true;
                epRoomId.SetError(tbRoomId, "Please enter only numbers");
            }

            foreach (var room in _rooms)
            {
                if (room.RoomId == _roomId)
                {
                    e.Cancel = true;
                    epRoomId.SetError(tbRoomId, "This id is already taken by another room");
                }
            }
        }

        private void tbRoomId_Validated(object sender, EventArgs e)
        {
            epRoomId.Clear();
        }

        private void CheckType()
        {
            if (cbRoomType.Text == "Single")
                type = RoomTypes.Single;
            else if (cbRoomType.Text == "Couple")
                type = RoomTypes.Couple;
            else if (cbRoomType.Text == "Family")
                type = RoomTypes.Family;
            else
                type = RoomTypes.Penthouse;
        }

        private void AddRoom(Room room)
        {
            string queryString = "insert into Rooms(Room_Id, Room_Type) values(@Room_Id, @Room_Type)";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                var insertCommand = new OleDbCommand(queryString, connection);
                insertCommand.Parameters.Add(new OleDbParameter("@Room_Id", room.RoomId));
                insertCommand.Parameters.Add(new OleDbParameter("@Room_Type", room.RoomType));

                insertCommand.ExecuteNonQuery();

                _rooms.Add(room);
            }
        }
    }
}
