using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenteeApp.Domain.Entities
{
    public class Mentor : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public List<Mentee> Mentees { get; set; }
        public List<MeetUp> MeetUpsAttended { get; set; }
    }
}
