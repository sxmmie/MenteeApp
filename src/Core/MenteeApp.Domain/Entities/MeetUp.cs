using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenteeApp.Domain.Entities
{
    public class MeetUp
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public int Attendance { get; set; }
        // public DateTime Date { get; set; }
        public DateTime MeetUpStartTime { get; set; }
        public DateTime MeetUpEndTime { get; set; }
        public DateTime UpdateMeetUpTopic { get; set; }
        public DateTime MeetUpCancelled { get; set; }
    }
}
