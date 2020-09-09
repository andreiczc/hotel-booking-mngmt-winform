using System;
using System.Collections.Generic;

namespace Assignment14
{
    [Serializable]
    public class Client
    {
        public List<Reservation> Reservations;
        public int ClientId { get; set; }
        public string FullName { get; set; }

        public Client(string fullName)
        {
            Reservations = new List<Reservation>();
            FullName = fullName;
        }

        public Client(int clientId, string fullName)
        {
            Reservations = new List<Reservation>();
            FullName = fullName;
            ClientId = clientId;
        }
    }
}