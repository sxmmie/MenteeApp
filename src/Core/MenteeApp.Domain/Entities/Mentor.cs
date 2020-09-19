using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenteeApp.Domain.Entities
{
    public class Mentor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Mentee> Mentees { get; set; }
        public List<MeetUp> MeetUpsAttended { get; set; }
    }
}
