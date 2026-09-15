using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using VetTechApi.Data;
using VetTechApi.Models;

namespace VetTechApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorController : ControllerBase
    {
        public readonly VetContext _context;

        public TutorController(VetContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tutor>>> GetTutor()
        {
            return await _context.Tutores.ToListAsync();
        }
        [HttpPost]
        public async Task<IActionResult> AddCurso(Tutor tutor)
        {
            _context.Tutores.Add(tutor);
            await _context.SaveChangesAsync();
            return Ok("Tutor cadastrado sucesso");
        }
    }
}