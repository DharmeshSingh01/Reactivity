﻿using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    // [Route("api/[controller]")]
    // [ApiController]
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;

        }
        [HttpGet]
       public  async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();
        }
        [HttpGet("{Id}")]
         public  async Task<ActionResult<Activity>> GetActivity( Guid Id)
        {
            return await _context.Activities.FindAsync(Id);
        }
    }
}
