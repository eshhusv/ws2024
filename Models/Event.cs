using System;
using System.Collections.Generic;

namespace BlazorApp1.Models
{
    public class Event
    {
        public int EventId { get; set; }

        public string EventCode { get; set; }

        public string EventName { get; set; } = null!;

        public DateOnly EventDate { get; set; }

        public string EvenetTime { get; set; }

        public string EventType { get; set; } = null!;

        public string EventResult { get; set; }

        public string EventRecommendations { get; set; }

        public int DoctorId { get; set; }

        public int PatientId { get; set; }

        public virtual Doctor Doctor { get; set; } = null!;

        public virtual Patient Patient { get; set; } = null!;
    }
}