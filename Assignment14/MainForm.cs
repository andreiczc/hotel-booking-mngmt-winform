using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using LineChart;

namespace Assignment14
{
    public partial class MainForm : Form
    {
        private const string ConnectionString =
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;Persist Security Info=True";

        public List<Room> Rooms;
        public List<Client> Clients;

        public MainForm()
        {
            InitializeComponent();
            Rooms = new List<Room>();
            Clients = new List<Client>();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                roomToolStripMenuItem.CheckState = CheckState.Checked;
                LoadRooms();
                DisplayRooms();
                LoadClients();
                LoadReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        public void DisplayRooms()
        {
            lvMulti.Items.Clear();
            foreach (var room in Rooms)
            {
                var lvItem = new ListViewItem(room.RoomId.ToString());
                lvItem.SubItems.Add(room.RoomType.ToString());
                lvItem.Tag = room;
                lvMulti.Items.Add(lvItem);
            }
        }

        public void DisplayClients()
        {
            lvMulti.Items.Clear();
            foreach (var client in Clients)
            {
                var lvItem = new ListViewItem(client.ClientId.ToString());
                lvItem.SubItems.Add(client.FullName);
                lvItem.Tag = client;
                lvMulti.Items.Add(lvItem);
            }
        }

        public void LoadRooms()
        {
            const string queryString = "SELECT * FROM Rooms";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                OleDbCommand sqlCommand = new OleDbCommand(queryString, connection);
                OleDbDataReader sqlReader = sqlCommand.ExecuteReader();
                try
                {
                    while (sqlReader.Read())
                    {
                        var room = new Room(
                            (int) sqlReader["Room_Id"],
                            (RoomTypes) sqlReader["Room_Type"]);
                        Rooms.Add(room);
                    }
                }
                finally
                {
                    sqlReader.Close();
                }
            }
        }

        public void LoadClients()
        {
            const string queryString = "SELECT * FROM Clients";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                OleDbCommand sqlCommand = new OleDbCommand(queryString, connection);
                OleDbDataReader sqlReader = sqlCommand.ExecuteReader();
                try
                {
                    while (sqlReader.Read())
                    {
                        var client = new Client(
                            (int)sqlReader["ID"],
                            (string)sqlReader["FullName"]);
                        Clients.Add(client);
                    }
                }
                finally
                {
                    sqlReader.Close();
                }
            }
        }

        public void LoadReservations()
        {
            const string queryString = "SELECT * FROM Reservations";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                OleDbCommand sqlCommand = new OleDbCommand(queryString, connection);
                OleDbDataReader sqlReader = sqlCommand.ExecuteReader();
                try
                {
                    while (sqlReader.Read())
                    {
                        var reservation = new Reservation((int) sqlReader["ReservationId"], (int) sqlReader["ClientId"],
                            (int) sqlReader["RoomId"],
                            (DateTime) sqlReader["StartDate"], (DateTime) sqlReader["EndDate"],
                            (RoomTypes) sqlReader["RoomType"], (string) sqlReader["ClientFullName"]);
                        foreach (var client in Clients)
                        {
                            if (client.ClientId == reservation.ClientId)
                                client.Reservations.Add(reservation);
                        }
                        foreach (var room in Rooms)
                        {
                            if(room.RoomId == reservation.RoomId)
                                room.Reservations.Add(reservation);
                        }
                    }
                }
                finally
                {
                    sqlReader.Close();
                }
            }
        }

        private void lvReservations_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvMulti.Columns[0].Text == "Room Id")
            {
                Room room = lvMulti.SelectedItems[0].Tag as Room;
                var cf1 = new CheckForm(room.Reservations, Rooms);
                cf1.ShowDialog();
            }
            else
            {
                Client client = lvMulti.SelectedItems[0].Tag as Client;
                var cf1 = new CheckForm(client.Reservations, Rooms);
                cf1.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddReservationForm form = new AddReservationForm(Rooms, Clients);
            form.Show();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoomForm form = new AddRoomForm(Rooms);
            form.Show();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(lvMulti.Columns[0].Text == "Room Id")
                DisplayRooms();
            else
                DisplayClients();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientToolStripMenuItem.CheckState = CheckState.Unchecked;

            lvMulti.Columns.Clear();

            ColumnHeader roomId = new ColumnHeader();
            ColumnHeader roomType = new ColumnHeader();
            roomId.Text = "Room Id";
            roomType.Text = "Room Type";

            lvMulti.Columns.Add(roomId);
            lvMulti.Columns.Add(roomType);

            DisplayRooms();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomToolStripMenuItem.CheckState = CheckState.Unchecked;

            lvMulti.Columns.Clear();

            ColumnHeader clientId = new ColumnHeader();
            ColumnHeader FullName = new ColumnHeader();
            clientId.Text = "Client ID";
            FullName.Text = "Full Name";

            lvMulti.Columns.Add(clientId);
            lvMulti.Columns.Add(FullName);

            DisplayClients();
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream stream = File.Create("binary.dat"))
            {
                binaryFormatter.Serialize(stream, Rooms);
                binaryFormatter.Serialize(stream, Clients);
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = File.OpenRead("binary.dat"))
            {
                Rooms = formatter.Deserialize(stream) as List<Room>;
                Clients = formatter.Deserialize(stream) as List<Client>;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.E)
                editToolStripMenuItem.Visible = true;
            else if (e.Alt && e.KeyCode == Keys.B)
                binaryToolStripMenuItem.Visible = true;
        }

        private void printReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
        }

        private int _currentIndex;
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<Reservation> reservations = new List<Reservation>();

            for(int i=0; i<Rooms.Count; i++)
                for(int j=0; j<Rooms[i].Reservations.Count; j++)
                    reservations.Add(Rooms[i].Reservations[j]);


            Font font = new Font("Microsoft Sans Serif", 24);

            var pageSettings = printDocument.DefaultPageSettings;
           

            var intPrintAreaHeight = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            var intPrintAreaWidth = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;

            
            var marginLeft = pageSettings.Margins.Left;

            var marginTop = pageSettings.Margins.Top;


            if (printDocument.DefaultPageSettings.Landscape)
            {
                var intTemp = intPrintAreaHeight;
                intPrintAreaHeight = intPrintAreaWidth;
                intPrintAreaWidth = intTemp;
            }

            const int rowHeight = 40;
            var columnWidth = intPrintAreaWidth / 5;

           
            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;

            while (_currentIndex < reservations.Count)
            {
                var currentX = marginLeft;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    reservations[_currentIndex].ReservationId.ToString(),
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    reservations[_currentIndex].RoomId.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    reservations[_currentIndex].ClientFullName,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    reservations[_currentIndex].StartDate.Day+"/"+reservations[_currentIndex].StartDate.Month+"/"+
                    reservations[_currentIndex].StartDate.Year.ToString().Remove(0,2),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    reservations[_currentIndex].EndDate.Day + "/" + reservations[_currentIndex].EndDate.Month + "/" +
                    reservations[_currentIndex].EndDate.Year.ToString().Remove(0, 2),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);

                _currentIndex++;

                currentY += rowHeight;

                if (currentY + rowHeight > intPrintAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _currentIndex = 0;
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void generateChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineChartValues[] values = new LineChartValues[Rooms.Count];

            for (int i = 0; i < Rooms.Count; i++)
            {
                values[i] = new LineChartValues(Rooms[i].RoomId.ToString() ,Rooms[i].Reservations.Count);
            }

            var form = new StatisticsForm(values);
            form.Show();
        }
    }
}
