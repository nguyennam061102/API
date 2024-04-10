﻿namespace API.Dtos
{
    public class EventDTO
    {
        public string EventName { get; set; }
        public DateTime FirstClosureDate { get; set; }
        public DateTime FinalClosureDate { get; set; }
        public int DurationBetweenClosure { get; set; }
        public int FacultyID { get; set; }
    }
}
