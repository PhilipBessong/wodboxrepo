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
            new Exercise { exeId = 1, exeName = "Weighted WodBox Step-ups", VideoUrl = "https://localhost:7013/api/videos/weightedwodboxstepups.mp4", MobileUrl = "https://localhost:7013/api/videos/weightedwodboxstepupsmobile.mp4" },
            new Exercise { exeId = 2, exeName = "WodBox Jumps", VideoUrl = "https://localhost:7013/api/videos/wodboxjumps.mp4", MobileUrl = "https://localhost:7013/api/videos/wodboxjumpsmbl.mp4" },
            new Exercise { exeId = 3, exeName = "WodBox Step Overs", VideoUrl = "https://localhost:7013/api/videos/wodboxstepovers.mp4", MobileUrl = "https://localhost:7013/api/videos/wodboxstepoversmbl.mp4" },
            new Exercise { exeId = 4, exeName = "DB Front Rack Reverse Lunges", VideoUrl = "https://localhost:7013/api/videos/4.mp4", MobileUrl = "https://localhost:7013/api/videos/4mbl.mp4" },
            new Exercise { exeId = 5, exeName = "Single Arm DB Push-Press", VideoUrl = "https://localhost:7013/api/videos/wodboxjumps.mp4", MobileUrl = "https://localhost:7013/api/videos/wodboxjumps.mp4" },
            new Exercise { exeId = 6, exeName = "Dumbbell Front Rack Squat", VideoUrl = "https://localhost:7013/api/videos/wodboxjumps.mp4", MobileUrl = "https://localhost:7013/api/videos/wodboxjumps.mp4" },
            new Exercise { exeId = 7, exeName = "High Plank Dumbbell Drag Across", VideoUrl = "https://localhost:7013/api/videos/wodboxjumps.mp4", MobileUrl = "https://localhost:7013/api/videos/wodboxjumps.mp4" },
            new Exercise { exeId = 8, exeName = "KB Single Leg Romanian Deadlift", VideoUrl = "https://localhost:7013/api/videos/wodboxjumps.mp4", MobileUrl = "https://localhost:7013/api/videos/wodboxjumps.mp4" },
            new Exercise { exeId = 9, exeName = "Russian Twists with Dumbell", VideoUrl = "https://localhost:7013/api/videos/wodboxjumps.mp4", MobileUrl = "https://localhost:7013/api/videos/wodboxjumps.mp4" },
            new Exercise { exeId = 10, exeName = "Upright Kettlebell Row", VideoUrl = "https://localhost:7013/api/videos/wodboxjumps.mp4", MobileUrl = "https://localhost:7013/api/videos/wodboxjumps.mp4" }
        };
        [HttpGet]
        public IActionResult GetExercises()
        {
            return Ok(_exercises);
        }

       // [HttpGet("{exeName}")]
       // public IActionResult GetVideoByName(string exeName)
       // {
     //       var exercise = _exercises.FirstOrDefault(v => v.exeName.ToLower() == exeName.ToLower());
     
       //     if (exercise == null)
      //      {
      //          return NotFound($"Video with name '{exeName}' not found.");
      //      }

       //     return Ok(exercise);
      //  }

        private readonly string videosFolderPath = "videos";
        [HttpGet("{videoName}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FileStreamResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetVideo(string videoName)
        {
            var videoPath = Path.Combine(videosFolderPath, videoName);

            if (!System.IO.File.Exists(videoPath))
            {
                Console.WriteLine($"File not found: {videoPath}");
                return NotFound(new { error = $"Video with name '{videoName}' not found." });
            }

            var fileStream = new FileStream(videoPath, FileMode.Open, FileAccess.Read);
            return new FileStreamResult(fileStream, "video/mp4");
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
