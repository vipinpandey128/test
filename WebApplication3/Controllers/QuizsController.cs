﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.DbContexts;
using WebApplication3.Model;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication3.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class QuizsController : ControllerBase
    {
        private readonly DataContext _context;

        public QuizsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Quizs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quiz>>> GetQuizs()
        {
            return await _context.Quizs.ToListAsync();
        }

        // GET: api/Quizs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Quiz>> GetQuiz(int id)
        {
            var quiz = await _context.Quizs.FindAsync(id);

            if (quiz == null)
            {
                return NotFound();
            }

            return quiz;
        }

        // PUT: api/Quizs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuiz(int id, Quiz quiz)
        {
            if (id != quiz.QuizID)
            {
                return BadRequest();
            }

            _context.Entry(quiz).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuizExists(id))
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

        // POST: api/Quizs
        [HttpPost]
        public async Task<ActionResult<Quiz>> PostQuiz(Quiz quiz)
        {
            _context.Quizs.Add(quiz);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuiz", new { id = quiz.QuizID }, quiz);
        }

        // DELETE: api/Quizs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Quiz>> DeleteQuiz(int id)
        {
            var quiz = await _context.Quizs.FindAsync(id);
            if (quiz == null)
            {
                return NotFound();
            }

            _context.Quizs.Remove(quiz);
            await _context.SaveChangesAsync();

            return quiz;
        }

        private bool QuizExists(int id)
        {
            return _context.Quizs.Any(e => e.QuizID == id);
        }
    }
}
