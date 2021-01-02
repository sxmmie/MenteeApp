using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenteeApp.Domain.Entities
{
    public class MeetUp : BaseEntity
    {
        public string Topic { get; set; }
        public int Attendance { get; set; }
        // public DateTime Date { get; set; }
        public DateTimeOffset MeetUpStartTime { get; set; }
        public DateTimeOffset MeetUpEndTime { get; set; }
        public DateTimeOffset UpdateMeetUpTopic { get; set; }
        public DateTimeOffset MeetUpCancelled { get; set; }
    }
}
