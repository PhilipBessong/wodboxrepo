using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using wodapi.Models;

namespace wodapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

        public UsersController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            return await _context.Users.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.userId)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
          if (_context.Users == null)
          {
              return Problem("Entity set 'AppDbContext.Users'  is null.");
          }
            // Check if the username is already taken
            if (_context.Users.Any(u => u.email == user.email))
            {
                return BadRequest("Username already exists");
            }
            
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.userId }, user);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User login)
        {
            var user = _context.Users.SingleOrDefault(u => u.email == login.email && u.password == login.password);

            if (user == null)
            {
                return Unauthorized("Invalid username or password");
            }

            // In a real-world scenario, generate and return a JWT token here
            // Check usertypeid and include it as a claim
            string role = user.role;
            var token = GenerateJwtToken(user.email, role);
            return Ok(new { Token = token });
        }
        private string GenerateJwtToken(string email, string role)
        {
            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["Jwt:SecretKey"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddMinutes(Convert.ToDouble(_configuration["Jwt:ExpirationInMinutes"]));

            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, email),
            new Claim("role", role), // Add usertypeid as a claim
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: expires,
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

      
        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return (_context.Users?.Any(e => e.userId == id)).GetValueOrDefault();
        }

        // ... (your existing code)
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] UserResetPasswordRequest resetRequest)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.email == resetRequest.Email);

            if (user == null)
            {
                return NotFound("User not found");
            }

            // Generate a unique reset token (you may want to use a library for this)
            var resetToken = Guid.NewGuid().ToString();

            // Store the reset token and its expiration date in the database
            user.ResetToken = resetToken;
            user.ResetTokenExpiration = DateTime.Now.AddHours(1); // Reset token expires in 1 hour

            await _context.SaveChangesAsync();

            // Send the reset token to the user's email
            SendResetTokenEmail(user.email, resetToken);


            return Ok("Password reset token sent successfully");
        }

        [HttpPost("complete-reset-password")]
        public async Task<IActionResult> CompleteResetPassword([FromBody] UserCompleteResetPasswordRequest resetRequest)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.email == resetRequest.Email);

            if (user == null)
            {
                return NotFound("User not found");
            }

            // Check if the reset token is valid and not expired
            if (user.ResetToken != resetRequest.ResetToken || user.ResetTokenExpiration < DateTime.Now)
            {
                return BadRequest("Invalid or expired reset token");
            }

            // Update the password and clear the reset token
            user.password = resetRequest.NewPassword;
            user.ResetToken = null;
            user.ResetTokenExpiration = null;

            await _context.SaveChangesAsync();

            return Ok("Password reset successfully");
        }


        // ... (your existing code)
        private void SendResetTokenEmail(string userEmail, string resetToken)
        {
            // TODO: Replace these values with your SMTP server configuration
            string smtpHost = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "pba.bessong@gmail.com";
            string smtpPassword = "M@k3M0n3y";

            try
            {
                using (var client = new SmtpClient(smtpHost, smtpPort))
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);
                    client.EnableSsl = true;

                    var message = new MailMessage();
                    message.From = new MailAddress("pba.bessong@gmail.com");
                    message.To.Add(new MailAddress(userEmail));
                    message.Subject = "Password Reset";
                    message.Body = $"Your password reset token is: {resetToken}";

                    client.Send(message);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (log, return an error response, etc.)
                Console.WriteLine($"Error sending email: {ex.Message}");
                // You might want to throw the exception if you want to propagate it further
                // throw;
            }
        }


    }

    public class UserCompleteResetPasswordRequest
    {
        public string Email { get; set; }
        public string ResetToken { get; set; }
        public string NewPassword { get; set; }
    }

    public class UserResetPasswordRequest
    {
        public string Email { get; set; }
        public string ResetToken { get; set; }
        public string NewPassword { get; set; }
    }
    

}
