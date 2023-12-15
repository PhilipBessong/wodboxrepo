using System;
using System.Collections.Generic;
using System.Linq;
using Google.Cloud.Storage.V1;
using Google.Apis.Auth.OAuth2;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using wodapi.Models;
using DocumentFormat.OpenXml.Presentation;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Wordprocessing;

namespace wodapi.Controllers
{
    [Route("api/videos")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {
        private readonly List<Exercise> _exercises = new List<Exercise>
        {
            new Exercise { exeId = 1, exeName = "Weighted WodBox Step-ups", VideoUrl = "https://storage.cloud.google.com/wodboxvids/1.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/1mbl.mp4" },
            new Exercise { exeId = 2, exeName = "WodBox Jumps", VideoUrl = "https://storage.cloud.google.com/wodboxvids/2.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/2mbl.mp4" },
            new Exercise { exeId = 3, exeName = "WodBox Step Overs", VideoUrl = "https://storage.cloud.google.com/wodboxvids/3.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/3mbl.mp4" },
            new Exercise { exeId = 4, exeName = "DB Front Rack Reverse Lunges", VideoUrl = "https://storage.cloud.google.com/wodboxvids/4.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/4mbl.mp4" },
            new Exercise { exeId = 5, exeName = "Single Arm DB Push-Press", VideoUrl = "https://storage.cloud.google.com/wodboxvids/5.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/5mbl.mp4" },
            new Exercise { exeId = 6, exeName = "Dumbbell Front Rack Squat", VideoUrl = "https://storage.cloud.google.com/wodboxvids/6.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/6mbl.mp4" },
            new Exercise { exeId = 7, exeName = "High Plank Dumbbell Drag Across", VideoUrl = "https://storage.cloud.google.com/wodboxvids/7.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/7mbl.mp4" },
            new Exercise { exeId = 8, exeName = "KB Single Leg Romanian Deadlift", VideoUrl = "https://storage.cloud.google.com/wodboxvids/8.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/8mbl.mp4" },
            new Exercise { exeId = 9, exeName = "Russian Twists with Dumbell", VideoUrl = "https://storage.cloud.google.com/wodboxvids/9.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/9mbl.mp4" },
            new Exercise { exeId = 10, exeName = "Upright Kettlebell Row", VideoUrl = "https://storage.cloud.google.com/wodboxvids/10.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/10mbl.mp4" },
            new Exercise { exeId = 11, exeName = "Burpee", VideoUrl = "https://storage.cloud.google.com/wodboxvids/11.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/11mbl.mp4" },
            new Exercise { exeId = 12, exeName = "Mountain Climbers", VideoUrl = "https://storage.cloud.google.com/wodboxvids/12.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/12mbl.mp4" },
            new Exercise { exeId = 13, exeName = "Glute Bridges", VideoUrl = "https://storage.cloud.google.com/wodboxvids/13.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/13mbl.mp4" },
            new Exercise { exeId = 14, exeName = "Pike Push-ups (Feet on Box)", VideoUrl = "https://storage.cloud.google.com/wodboxvids/14.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/14mbl.mp4" },
            new Exercise { exeId = 15, exeName = "Burpee WodBox Jump", VideoUrl = "https://storage.cloud.google.com/wodboxvids/15.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/15mbl.mp4" },
            new Exercise { exeId = 16, exeName = "Bulgarian Split Squats", VideoUrl = "https://storage.cloud.google.com/wodboxvids/16.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/16mbl.mp4" },
            new Exercise { exeId = 17, exeName = "Single Arm Rows on Box", VideoUrl = "https://storage.cloud.google.com/wodboxvids/17.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/17mbl.mp4" },
            new Exercise { exeId = 18, exeName = "Thrusters Single Arm DB", VideoUrl = "https://storage.cloud.google.com/wodboxvids/18.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/18mbl.mp4" },
            new Exercise { exeId = 19, exeName = "Clean and Jerk with Dumbbells", VideoUrl = "https://storage.cloud.google.com/wodboxvids/19.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/19mbl.mp4" },
            new Exercise { exeId = 20, exeName = "Weighted Sit-ups (Single Hand DB)", VideoUrl = "https://storage.cloud.google.com/wodboxvids/20.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/20mbl.mp4" },
            new Exercise { exeId = 21, exeName = "Sumo Deadlift", VideoUrl = "https://storage.cloud.google.com/wodboxvids/21.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/21mbl.mp4" },
            new Exercise { exeId = 22, exeName = "Sumo Deadlift High Pull", VideoUrl = "https://storage.cloud.google.com/wodboxvids/22.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/22mbl.mp4" },
            new Exercise { exeId = 23, exeName = "Triceps Overhead Extension", VideoUrl = "https://storage.cloud.google.com/wodboxvids/23.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/23mbl.mp4" },
            new Exercise { exeId = 24, exeName = "Dumbbell Snatches Alternating", VideoUrl = "https://storage.cloud.google.com/wodboxvids/24.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/24mbl.mp4" },
            new Exercise { exeId = 25, exeName = "Push-up Kick Through", VideoUrl = "https://storage.cloud.google.com/wodboxvids/25.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/25mbl.mp4" },
            new Exercise { exeId = 26, exeName = "Plank", VideoUrl = "https://storage.cloud.google.com/wodboxvids/26.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/26mbl.mp4" },
            new Exercise { exeId = 27, exeName = "Shoulder Taps", VideoUrl = "https://storage.cloud.google.com/wodboxvids/27.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/27mbl.mp4" },
            new Exercise { exeId = 28, exeName = "Box Jump Over", VideoUrl = "https://storage.cloud.google.com/wodboxvids/28.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/28mbl.mp4" },
            new Exercise { exeId = 29, exeName = "WodBox Dips", VideoUrl = "https://storage.cloud.google.com/wodboxvids/29.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/29mbl.mp4" },
            new Exercise { exeId = 30, exeName = "Elevated WodBox Push-ups", VideoUrl = "https://storage.cloud.google.com/wodboxvids/30.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/30mbl.mp4" },
            new Exercise { exeId = 31, exeName = "WodBox Toe Taps", VideoUrl = "https://storage.cloud.google.com/wodboxvids/31.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/31mbl.mp4" },
            new Exercise { exeId = 32, exeName = "WodBox Leg Tucks", VideoUrl = "https://storage.cloud.google.com/wodboxvids/32.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/32mbl.mp4" },
            new Exercise { exeId = 33, exeName = "Hang Clean & Jerk", VideoUrl = "https://storage.cloud.google.com/wodboxvids/33.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/33mbl.mp4" },
            new Exercise { exeId = 34, exeName = "Man Makers (Single Arm)", VideoUrl = "https://storage.cloud.google.com/wodboxvids/34.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/34mbl.mp4" },
            new Exercise { exeId = 35, exeName = "Kettlebell Swings", VideoUrl = "https://storage.cloud.google.com/wodboxvids/35.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/35mbl.mp4" },
            new Exercise { exeId = 36, exeName = "Goblet Squat", VideoUrl = "https://storage.cloud.google.com/wodboxvids/36.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/36mbl.mp4" },
            new Exercise { exeId = 37, exeName = "Kettlebell Bicep Curl", VideoUrl = "https://storage.cloud.google.com/wodboxvids/37.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/37mbl.mp4" },
            new Exercise { exeId = 38, exeName = "Overhead Reverse Lunges", VideoUrl = "https://storage.cloud.google.com/wodboxvids/38.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/38mbl.mp4" },
            new Exercise { exeId = 39, exeName = "Push-ups", VideoUrl = "https://storage.cloud.google.com/wodboxvids/39.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/39mbl.mp4" },
            new Exercise { exeId = 40, exeName = "Sit-ups", VideoUrl = "https://storage.cloud.google.com/wodboxvids/40.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/40mbl.mp4" },
            new Exercise { exeId = 41, exeName = "Squat Jump", VideoUrl = "https://storage.cloud.google.com/wodboxvids/41.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/41mbl.mp4" },
            new Exercise { exeId = 42, exeName = "Jumping Jacks", VideoUrl = "https://storage.cloud.google.com/wodboxvids/42.mp4", MobileUrl = "https://storage.cloud.google.com/wodboxvids/42mbl.mp4" },


        };
        [HttpGet]
        public IActionResult GetExercises()
        {
            return Ok(_exercises);
        }



        [HttpGet("byName/{exeName}")]
        public IActionResult GetExerciseByName(string exeName)
        {
            // Find the exercise with the specified name
            var exercise = _exercises.FirstOrDefault(e => e.exeName.ToLower() == exeName.ToLower());

            // If exercise is not found, return NotFound
            if (exercise == null)
            {
                return NotFound($"Exercise with name '{exeName}' not found.");
            }

            return Ok(exercise);
        }

    }


}
