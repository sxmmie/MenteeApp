﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenteeApp.Domain.Entities
{
    public class Mentee : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        // public MeetUp MeetupId { get; set; }
        public Mentor Mentor { get; set; }
        public List<MeetUp> MeetUpsAttended { get; set; }
    }
}
