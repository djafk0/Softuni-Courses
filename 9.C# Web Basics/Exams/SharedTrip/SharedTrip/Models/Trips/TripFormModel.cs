﻿namespace SharedTrip.Models.Trips
{
    public class TripFormModel
    {
        public string Id { get; set; }

        public string StartPoint { get; set; }

        public string EndPoint { get; set; }

        public int Seats { get; set; }

        public string ImagePath { get; set; }

        public string Description { get; set; }

        public string DepartureTime { get; set; }
    }
}
