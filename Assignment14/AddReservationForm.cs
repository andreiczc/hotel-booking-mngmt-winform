using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment14
{
    public partial class AddReservationForm : Form
    {
        public List<Room> Rooms;
        public List<Client> Clients;

        public AddReservationForm(List<Room> rooms, List<Client> clients)
        {
            InitializeComponent();
            Rooms = rooms;
            Clients = clients;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewClientForm form = new NewClientForm(Rooms, Clients);
            form.Show();
            this.Close();
        }

        private void btnExisting_Click(object sender, EventArgs e)
        {
            ExistingClientForm form = new ExistingClientForm(Rooms, Clients);
            form.Show();
            this.Close();
        }

    }
}
