using System;

namespace Assignment14
{
    [Serializable]
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int RoomId { get; set; }
        public int ClientId { get; set; }
        public string ClientFullName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Reservation(Client client, Room room, DateTime startDate, DateTime endDate, RoomTypes roomType)
        {
            RoomId = room.RoomId;
            ClientFullName = client.FullName;
            ClientId = client.ClientId;
            StartDate = startDate;
            EndDate = endDate;
            room.Reservations.Add(this);
            client.Reservations.Add(this);
        }

        public Reservation(int reservationId, Client client, Room room, DateTime startDate, DateTime endDate, RoomTypes roomType)
        {
            ReservationId = reservationId;
            RoomId = room.RoomId;
            ClientFullName = client.FullName;
            ClientId = client.ClientId;
            StartDate = startDate;
            EndDate = endDate;
            room.Reservations.Add(this);
            client.Reservations.Add(this);
        }

        public Reservation(int reservationId, int clientId, int roomId, DateTime startDate, DateTime endDate, RoomTypes roomType, string clientFullName)
        {
            ReservationId = reservationId;
            ClientFullName = clientFullName;
            RoomId = roomId;
            ClientId = clientId;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}