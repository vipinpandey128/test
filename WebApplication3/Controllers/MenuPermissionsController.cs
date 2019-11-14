using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.DbContexts;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MenuPermissionsController : ControllerBase
    {
        private readonly DataContext _context;

        public MenuPermissionsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/MenuPermissions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuPermission>>> GetMenuPermissions()
        {
            return await _context.MenuPermissions.ToListAsync();
        }

        // GET: api/MenuPermissions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MenuPermission>> GetMenuPermission(long id)
        {
            var menuPermission = await _context.MenuPermissions.FindAsync(id);

            if (menuPermission == null)
            {
                return NotFound();
            }

            return menuPermission;
        }

        // PUT: api/MenuPermissions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenuPermission(long id, MenuPermission menuPermission)
        {
            if (id != menuPermission.mPID)
            {
                return BadRequest();
            }

            _context.Entry(menuPermission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuPermissionExists(id))
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

        // POST: api/MenuPermissions
        [HttpPost]
        public async Task<ActionResult<MenuPermission>> PostMenuPermission(MenuPermission menuPermission)
        {
            _context.MenuPermissions.Add(menuPermission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMenuPermission", new { id = menuPermission.mPID }, menuPermission);
        }

        // DELETE: api/MenuPermissions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MenuPermission>> DeleteMenuPermission(long id)
        {
            var menuPermission = await _context.MenuPermissions.FindAsync(id);
            if (menuPermission == null)
            {
                return NotFound();
            }

            _context.MenuPermissions.Remove(menuPermission);
            await _context.SaveChangesAsync();

            return menuPermission;
        }

        private bool MenuPermissionExists(long id)
        {
            return _context.MenuPermissions.Any(e => e.mPID == id);
        }
    }
}
