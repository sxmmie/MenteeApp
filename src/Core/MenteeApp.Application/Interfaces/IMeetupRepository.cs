using MenteeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenteeApp.Application.Interfaces
{
    public interface IMeetupRepository
    {
        Task<IReadOnlyList<MeetUp>> GetAllMeetUpsAsync();

        Task<MeetUp> GetMeetupByIdAsync(int id);
    }
}
