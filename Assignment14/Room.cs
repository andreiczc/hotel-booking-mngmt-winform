using System;
using System.Collections.Generic;

namespace Assignment14
{
    [Serializable]
    public class Room
    {
        public List<Reservation> Reservations;
        public int RoomId;
        public RoomTypes RoomType;

        public Room(RoomTypes roomType)
        {
            Reservations = new List<Reservation>();
            RoomType = roomType;
        }

        public Room(int roomId, RoomTypes roomType)
        {
            Reservations = new List<Reservation>();
            RoomType = roomType;
            RoomId = roomId;
        }
    }
}