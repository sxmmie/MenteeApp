using MenteeApp.Application.Interfaces;
using MenteeApp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenteeApp.API.Controllers
{
    public class MeetUpController : BaseController
    {
        private readonly IGenericRepository<MeetUp> _genericRepository;

        public MeetUpController(IGenericRepository<MeetUp> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<ActionResult<MeetUp>> GetMeetUps()
        {
            var meetups = await _genericRepository.ListAllAsync();

            return Ok(meetups);
        }
    }
}
