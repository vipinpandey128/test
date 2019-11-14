using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.DbContexts;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmailVerificationsController : ControllerBase
    {
        private readonly DataContext _context;

        public EmailVerificationsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/EmailVerifications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmailVerification>>> GetEmailVerifications()
        {
            return await _context.EmailVerifications.ToListAsync();
        }

        // GET: api/EmailVerifications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmailVerification>> GetEmailVerification(long id)
        {
            var emailVerification = await _context.EmailVerifications.FindAsync(id);

            if (emailVerification == null)
            {
                return NotFound();
            }

            return emailVerification;
        }

        // PUT: api/EmailVerifications/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmailVerification(long id, EmailVerification emailVerification)
        {
            if (id != emailVerification.vID)
            {
                return BadRequest();
            }

            _context.Entry(emailVerification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmailVerificationExists(id))
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

        // POST: api/EmailVerifications
        [HttpPost]
        public async Task<ActionResult<EmailVerification>> PostEmailVerification(EmailVerification emailVerification)
        {
            _context.EmailVerifications.Add(emailVerification);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmailVerification", new { id = emailVerification.vID }, emailVerification);
        }

        // DELETE: api/EmailVerifications/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmailVerification>> DeleteEmailVerification(long id)
        {
            var emailVerification = await _context.EmailVerifications.FindAsync(id);
            if (emailVerification == null)
            {
                return NotFound();
            }

            _context.EmailVerifications.Remove(emailVerification);
            await _context.SaveChangesAsync();

            return emailVerification;
        }

        private bool EmailVerificationExists(long id)
        {
            return _context.EmailVerifications.Any(e => e.vID == id);
        }
    }
}
