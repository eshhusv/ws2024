﻿using System;
using System.Collections.Generic;

namespace BlazorApp1.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        public string Firstname { get; set; } = null!;

        public string Surname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public string PassportSeriesAndNumber { get; set; } = null!;

        public DateOnly BirthDate { get; set; }

        public string Gender { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string MedicalCard { get; set; } = null!;

        public int InsurancePolicy { get; set; }

        public DateOnly InsurancePolicyExpireDate { get; set; }

        public virtual ICollection<Event> Events { get; set; } = new List<Event>();

        public virtual MedicalCard MedicalCardNavigation { get; set; } = null!;
    }
}
