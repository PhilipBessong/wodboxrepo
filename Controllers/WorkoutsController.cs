using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wodapi.Models;

namespace wodapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public WorkoutsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Workouts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Workout>>> GetWorkouts()
        {
          if (_context.Workouts == null)
          {
              return NotFound();
          }
            return await _context.Workouts.ToListAsync();
        }

        // GET: api/Workouts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Workout>> GetWorkout(int id)
        {
          if (_context.Workouts == null)
          {
              return NotFound();
          }
            var workout = await _context.Workouts.FindAsync(id);

            if (workout == null)
            {
                return NotFound();
            }

            return workout;
        }

        [HttpGet("bycriteria")]
        public async Task<ActionResult<IEnumerable<Workout>>> GetWorkoutsByCriteria(
           [FromQuery] string wodCat,
           [FromQuery] DateTime date)
        {
            var workouts = await _context.Workouts
                .Where(w => w.wodCat == wodCat && w.daDate.Date == date.Date)
                .ToListAsync();

            if (workouts == null || workouts.Count == 0)
            {
                return NotFound();
            }

            return workouts;
        }

        // PUT: api/Workouts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkout(int id, Workout workout)
        {
            if (id != workout.id)
            {
                return BadRequest();
            }

            _context.Entry(workout).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkoutExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Workouts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Workout>> PostWorkout(Workout workout)
        {
            // Check if the specified workout type exists
            
          if (_context == null)
          {
                // The specified workout type doesn't exist; you can return an error response
                return Problem("Entity set 'AppDbContext.Users'  is null.");

            }
            // Associate the existing workout type with the new workout
            
            _context.Workouts.Add(workout);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkout", new { id = workout.id }, workout);
        }

        // DELETE: api/Workouts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkout(int id)
        {
            if (_context.Workouts == null)
            {
                return NotFound();
            }
            var workout = await _context.Workouts.FindAsync(id);
            if (workout == null)
            {
                return NotFound();
            }

            _context.Workouts.Remove(workout);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkoutExists(int id)
        {
            return (_context.Workouts?.Any(e => e.id == id)).GetValueOrDefault();
        }

       

        [HttpGet("by-category/{wodCat}/today")]
        public async Task<ActionResult<IEnumerable<Workout>>> GetWorkoutsByCategoryAndTodayAsync(string wodCat)
        {
            try
            {
                // Get today's date in the format yyyy-MM-dd
                DateTime today = DateTime.Now.Date;

                var workouts = await _context.Workouts
                    .Where(w => w.wodCat == wodCat && w.daDate.Date == today)
                    .ToListAsync();

                return Ok(workouts);
            }
            catch (Exception ex)
            {
                // Handle exceptions, log errors, and return an error response as needed
                return StatusCode(500, "An error occurred while fetching workouts.");
            }
        }
    }

}

