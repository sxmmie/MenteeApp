using System;
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
        public DateTime CreatedAt { get; set; }
        // public MeetUp MeetupId { get; set; }
        public Mentor MentorId { get; set; }
        public List<MeetUp> MeetUpsAttended { get; set; }
    }
}
