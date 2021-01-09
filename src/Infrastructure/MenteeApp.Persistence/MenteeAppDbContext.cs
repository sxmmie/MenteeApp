using MenteeApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenteeApp.Persistence
{
    public class MenteeAppDbContext : DbContext
    {
        public MenteeAppDbContext(DbContextOptions<MenteeAppDbContext> options)
            :base(options)
        {
        }

        public DbSet<MeetUp> MeetUps { get; set; }
        public DbSet<Mentee> Mentees { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
    }
}
